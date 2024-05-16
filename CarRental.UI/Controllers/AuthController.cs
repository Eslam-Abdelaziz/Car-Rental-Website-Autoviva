using CarRental.Application.Contracts;
using CarRental.Application.Helpers;
using CarRental.Data.Constants;
using CarRental.Data.Models.Entities;
using CarRental.UI.Models.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.WebUtilities;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace CarRental.UI.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }
  

        #region SignIn
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel req, string? ReturnUrl)
        {
            var errors = ModelState.ToArray();
            if (ModelState.IsValid)
            {
                var user
                    = await _userManager.FindByEmailAsync(req.Email);
                if (user == null) 
                {
                    ModelState.AddModelError("LoginFailed", "Invalid login attempt.");
                    return View(req);
                }
                var result = await _signInManager.PasswordSignInAsync(user, req.Password, req.RememberMe, false);
                if (result.Succeeded)
                {
                   return LocalRedirect(ReturnUrl ?? "/Home");
                }else if (result.IsNotAllowed) 
                {
                    return View(nameof(EmailConfirmation), new EmailConfirmationViewModel() 
                    { User = user, ReturnUrl = ReturnUrl });
                }
                else 
                {
                    ModelState.AddModelError("LoginFailed", "Invalid login attempt.");
                }
            }
            return View(req);
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl) 
        {
            if (_signInManager.IsSignedIn(User)) 
            {
                return Redirect(returnUrl ?? "/Home");
            }
            return View(new LoginViewModel() { ReturnUrl = returnUrl});
        }
        #endregion

        #region External Signin
        [AllowAnonymous]
        [HttpGet]
        public IActionResult ExternalLogin(string Providor,string? returnUrl)
        {
            var redirectUrl = Url.Action("ExternalCallback", "Auth",
                                    new { ReturnUrl = returnUrl });

            var properties =
                _signInManager.ConfigureExternalAuthenticationProperties(Providor, redirectUrl);

            return new ChallengeResult(Providor, properties);
        }

        public async Task<IActionResult> ExternalCallback(string? returnUrl = null, string? remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/Home");

            var loginViewModel = new LoginViewModel()
            {
                ReturnUrl = returnUrl,
            };
            if (remoteError != null)
            {
                ModelState
                    .AddModelError("ExternalError", $"Error from external provider: {remoteError}");

                return View(nameof(Login), loginViewModel);
            }
            // Get the login information about the user from the external login provider
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ModelState
                    .AddModelError("Custom Error", "Error Connecting To Google Service");

                return View(nameof(Login), loginViewModel);
            }

            // If the user already has a login (i.e if there is a record in AspNetUserLogins
            // table) then sign-in the user with this external login provider
            var signInResult = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider,
                info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            if (signInResult.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            // If there is no record in AspNetUserLogins table, the user may not have
            // a local account
            else
            {
                // Get the email claim value
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);
                if (email != null)
                {
                    // Create a new user without password if we do not have a user already
                    var user = await _userManager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        user = new User
                        {
                            UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Email = info.Principal.FindFirstValue(ClaimTypes.Email),
                            Firstname = info.Principal.FindFirstValue(ClaimTypes.GivenName),
                            Lastname = info.Principal.FindFirstValue(ClaimTypes.Surname),
                            EmailConfirmed = true
                        };

                       var result =  await _userManager.CreateAsync(user);
                       if (!result.Succeeded) 
                       {

                            if (result.Errors.FirstOrDefault()?.Code == "DuplicateUserName")
                            {
                                ModelState.AddModelError("SignUpFailed", "User Already Exsits. Try Sign in");
                            }
                            else
                            {
                                ModelState.AddModelError("SignUpFailed", "Error Signing Up Please try later");

                            }
                            return View(nameof(Login), loginViewModel);
                        }
                        await _userManager.AddToRoleAsync(user, Roles.Customer);
                    }

                    // Add a login (i.e insert a row for the user in AspNetUserLogins table)
                    await _userManager.AddLoginAsync(user, info);
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return LocalRedirect(returnUrl);
                }


                ModelState.AddModelError("CustomError", "Unexpected error please try again");
                return View(nameof(Login),loginViewModel);
            }
        }
        #endregion

        #region SignUp
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel req) 
        {
            if(ModelState.IsValid) 
            {
                var hasher = new PasswordHasher<User>();

                var user = new User()
                {
                    Firstname = req.FirstName,
                    Lastname = req.LastName,
                    Email = req.Email,
                    UserName = req.Email.ToLower(),
                    NormalizedUserName = req.Email.ToUpper(),
                    CreatedDate = DateTime.UtcNow,
                    EmailConfirmationToken = RandomHelper.GenerateConfirmationCode(8).ToString()
                };

                user.PasswordHash = hasher.HashPassword(user, req.Password);

                var result = await _userManager.CreateAsync(user);

                if (result.Succeeded) 
                {
                    await _userManager.AddToRoleAsync(user,Roles.Customer);
                    await _emailSender.SendEmailAsync(user.Email, "Confirm your email",
      $"Confirmation Code : {user.EmailConfirmationToken}");

                    return await EmailConfirmation(req.ReturnUrl,user.Id);
                }
                else if (result.Errors.FirstOrDefault()?.Code == "DuplicateUserName") 
                {
                    ModelState.AddModelError("SignUpFailed","User Already Exsits. Try Sign in");
                }
                else 
                {
                    ModelState.AddModelError("SignUpFailed", "Error Signing Up Please try later");

                }
            }
            return View(req);
        }

        [HttpGet]
        public IActionResult SignUp(string? returnUrl)
        {
            if (_signInManager.IsSignedIn(User))
            {
                return Redirect(returnUrl ?? "/Home");
            }
            return View(new SignUpViewModel() { ReturnUrl = returnUrl });
        }
        #endregion

        #region SignOut
        [HttpGet]
        public async Task<IActionResult> SignOutAsync() 
        {
           await _signInManager.SignOutAsync();
           return LocalRedirect(Url.Action(nameof(Login), "Auth")?? "/Home");
        }
        #endregion

        #region Reset Password
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel req)
        {
            if (ModelState.IsValid) 
            {
                var user = await _userManager.FindByEmailAsync(req.Email);
                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user))) 
                {
                    ModelState.AddModelError("CustomError","Cannot Reset Password.");
                }
                else 
                {
                    var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    string uid = user.Id;
                    string? url = Url.Action("ResetPassword", "Auth", new { code, uid }, Request.Scheme);

                    await _emailSender.SendEmailAsync(
                        req.Email,
                        "Reset Password",
                        $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(url ?? "")}'>clicking here</a>.");

                    req.IsSent = true;
                    View(req);
                }
            }
            return View(req);
        }

        [HttpGet]
        public IActionResult ForgotPassword() 
        {
            return View(new ForgotPasswordViewModel());
        }


        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel req) 
        {

            var errors = ModelState.ToList();
            if (ModelState.IsValid) 
            {
                var user = await _userManager.FindByIdAsync(req.Uid);
                if (user== null) 
                {
                    ModelState.AddModelError("CustomError","Error Resetting Password.");
                }
                else
                {
                    var Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(req.Code));

                    var result = await _userManager.ResetPasswordAsync(user, Code, req.Password);
                    var error = result.Errors.FirstOrDefault();
                    if (result.Succeeded)
                    {
                        req.IsReset = true;
                        return View(req);
                    }
                    //PasswordRequiresLower
                    //PasswordRequiresUpper
                    else if (error.Code == "InvalidToken") 
                    {
                        ModelState.AddModelError("CustomError", "invalid reset link");

                    }else if (error.Code == "PasswordRequiresLower") 
                    {
                        ModelState.AddModelError("CustomError", error.Description);
                    }
                    else if (error.Code == "PasswordRequiresUpper") 
                    {
                        ModelState.AddModelError("CustomError", error.Description);
                    }
                    else if (error.Code == "PasswordRequiresNonAlphanumeric") 
                    {
                        ModelState.AddModelError("CustomError", error.Description);
                    }
                    else 
                    {
                        ModelState.AddModelError("CustomError", "Error Resetting Password.");
                    }

                }
             
            }
            return View(req);
        }


        [HttpGet]
        public async Task<IActionResult> ResetPassword(ResetPasswordReq req) 
        {
            if (ModelState.IsValid) 
            {
                var user = await _userManager.FindByIdAsync(req.Uid);
                if (user == null) 
                {
                    ModelState.AddModelError("CustomError","error Resetting Password");
                }
                else 
                {
                    return View(new ResetPasswordViewModel()
                    {
                        Code = req.Code,
                        Uid = user.Id,
                        
                    });
                }
            }
            return View(new ResetPasswordViewModel());
        }


        #endregion

        #region Email Confirmation
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ModelState.ContainsKey("User"))
            {
                context.ModelState["User"].ValidationState = ModelValidationState.Valid;
            }
        }
        [HttpPost]
        public async Task<IActionResult> EmailConfirmation(EmailConfirmationViewModel req) 
        {
            var user = await _userManager.FindByIdAsync(req.Uid);
            req.User = user;

            var error = ModelState.Values.ToArray();
            if (ModelState.IsValid) 
            {
                if (user != null)
                {
                    if (!user.EmailConfirmed)
                    {
                        if (req.Code.ToString() == user.EmailConfirmationToken) 
                        {
                            user.EmailConfirmed = true;
                            await _userManager.UpdateAsync(user);
                            req.IsConfirmed = true;
                        }
                        else 
                        {
                            ModelState.AddModelError("CustomError","Code is not vaild.");
                        }
                    }
                }
                else 
                {
                    return LocalRedirect(req.ReturnUrl ?? "Home");
                }
            }
            return View(req);
        }

        [HttpGet]
        public async Task<IActionResult> EmailConfirmation(string? returnUrl,string uid)
        {
            var user = await _userManager.FindByIdAsync(uid);

            if (user != null)
            {
                if (!user.EmailConfirmed)
                {
                    return View(nameof(EmailConfirmation),new EmailConfirmationViewModel() { User = user, ReturnUrl = returnUrl });
                }
            }
            return LocalRedirect(returnUrl ?? "/Home");

        }

        [HttpGet]
        public async Task<IActionResult> Resend(string uid) 
        {
            var user = await _userManager.FindByIdAsync(uid);
            if (user != null)
            {
                if (!user.EmailConfirmed)
                {
                    user.EmailConfirmationToken = RandomHelper.GenerateConfirmationCode(8).ToString();
                    await _userManager.UpdateAsync(user);
                    await _emailSender.SendEmailAsync(user.Email, "Confirm your email", $"Confirmation Code : {user.EmailConfirmationToken}");

                    return View(nameof(EmailConfirmation), new EmailConfirmationViewModel()
                    {
                        User = user,
                        IsResent = true,
                    });;
                }
            }
            return LocalRedirect("/Home");

        }
        #endregion


        public IActionResult Index() 
        {
            return View(nameof(Login),new LoginViewModel());
        }
    }
}

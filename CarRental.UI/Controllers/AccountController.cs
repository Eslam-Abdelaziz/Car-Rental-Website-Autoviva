using CarRental.Application.Contracts;
using CarRental.Application.Contracts.Entities;
using CarRental.Data.Models.Entities;
using CarRental.UI.Models;
using CarRental.UI.Models.Account;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Text.Encodings.Web;

namespace CarRental.UI.Controllers
{
	[Authorize]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IEmailSender _emailSender;
        private readonly IFavouritesService _favouritesService;
        private readonly IRentalService _rentalService;
        private readonly IAddressService _addressService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, IFavouritesService favouritesService, IRentalService rentalService, ICarService carService, IAddressService addressService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _favouritesService = favouritesService;
            _rentalService = rentalService;
            _addressService = addressService;
        }
        public async Task<IActionResult> BillingAsync(AddressChangeRequest req) 
        {

            var address = new Address() 
            {
                City = req.City,
                Phone = req.Phone,
                State = req.State,
                ZipCode = req.ZipCode,
                Street = req.Street,
            };
            if (ModelState.IsValid) 
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    return NotFound();
                }
                var userAddress = await _addressService.AsQueryable().FirstOrDefaultAsync(ad=>ad.UserId == user.Id);
                ViewBag.IsUpdated = true;
                if (userAddress == null) 
                {
                    address.UserId = user.Id;
                    return View(await _addressService.Add(address));
                }
                else 
                {
                    userAddress.ZipCode = req.ZipCode;
                    userAddress.Street = req.Street;
                    userAddress.City = req.City;
                    userAddress.Phone = req.Phone;
                    userAddress.State = req.State;
                    await _addressService.Update(userAddress);
                    return View(userAddress);
                }
            }
            return View(address);
        }



        [HttpGet]
        public async Task<IActionResult> BillingAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            var userAddress = await _addressService.AsQueryable().FirstOrDefaultAsync(ad => ad.UserId == user.Id);

            return View(userAddress ?? new Address());
        }

        [HttpGet]
        public async Task<IActionResult> RentalsAsync(int? page = 1)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            if (page < 1)
            {
                page = 1;
            }
            if (TempData["RentalMsg"] != null) 
            {
                ViewBag.RentalMsg = TempData["RentalMsg"];
            }
            if (TempData["RentalError"] != null)
            {
                ViewBag.RentalMsg = TempData["RentalMsg"];
            }
            return View(await PaginatedList<Rental>.CreateAsync(_rentalService.AsQueryable()
                .Where(x=>x.UserId == user.Id)
                .Include(x => x.Car)
                .Include(x=>x.ReturnBranch)
                .Include(x=>x.Payment).OrderByDescending(x=>x.RentDate), page ?? 1, 4));
        }

        #region Settings
        [HttpPost]
        public async Task<IActionResult> Changepassword(PasswordChangeViewModel req) 
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            bool IsEmptyPassword = user.PasswordHash == null;
           
            if (IsEmptyPassword) 
            {
                ModelState.Remove(nameof(PasswordChangeViewModel.CurrentPassword));
            }

            var model = new SettingsViewModel();
            model.PasswordChange = req;
            model.ProfileDetails.Firstname = user.Firstname;
            model.ProfileDetails.Email = user.Email;
            model.ProfileDetails.Lastname = user.Lastname;
            model.ProfileDetails.IsEmptyPassword = IsEmptyPassword;

            if (ModelState.IsValid)
            {
                IdentityResult result;  
                if (IsEmptyPassword) 
                {
                    result = await _userManager.AddPasswordAsync(user,req.ConfirmPassword);
                }
                else 
                {
                     result = await _userManager.ChangePasswordAsync(user, req.CurrentPassword, req.ConfirmPassword);
                }

                var error = result.Errors.FirstOrDefault();
                if (result.Succeeded) 
                {
                    model.ProfileDetails.IsEmptyPassword = false;
                    model.PasswordChange.IsChanged = true;
                    model.PasswordChange.ConfirmPassword = "";
                    model.PasswordChange.CurrentPassword = "";
                    model.PasswordChange.Password = "";
                }
                else if(error.Code == "PasswordMismatch")
                {
                    ModelState.AddModelError("CustomError", error.Description);
                }else 
                {
                    ModelState.AddModelError("CustomError", string.Format("Error {0} Password.", IsEmptyPassword ? "Create" : "Change"));
                }
            }

            return View(nameof(Settings), model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> ChangeEmail(ChangeEmailViewModel req) 
        {
            if (ModelState.IsValid) 
            {
                var user = await _userManager.FindByIdAsync(req.Uid);
                if (user == null)
                {
                    ModelState.AddModelError("CustomError", "Error Resetting Password.");
                }
                else
                {
                    var Code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(req.Code));



                    var result = await _userManager.ChangeEmailAsync(user, req.Email , Code);

                    var error = result.Errors.FirstOrDefault();
                    if (result.Succeeded)
                    {
                        user.UserName = req.Email;
                        user.NormalizedUserName = req.Email.ToUpper();
                        await _userManager.UpdateAsync(user);
                        req.IsEmailChanged = true;
                        return View(req);
                    }
                    //PasswordRequiresLower
                    //PasswordRequiresUpper
                    else if (error.Code == "InvalidToken")
                    {
                        ModelState.AddModelError("CustomError", "invalid reset link");

                    }
                    else
                    {
                        ModelState.AddModelError("CustomError", "Error Changine Email.");
                    }

                }
            }
            return View(req);
        }

        [HttpPost]
        public async Task<IActionResult> Updateinfo(ProfileDetailsViewModel profile)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound();
            }
            var model = new SettingsViewModel();
            if (ModelState.IsValid) 
            {
                if (user.Email != profile.Email) 
                {
                    var code = await _userManager.GenerateChangeEmailTokenAsync(user, profile.Email);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    string uid = user.Id;
                    string? url = Url.Action("ChangeEmail", "Account", new { code, email = profile.Email, uid }, Request.Scheme);
                    profile.IsEmailChanged = true;
                    await _emailSender.SendEmailAsync(
                        user.Email,
                        "Change Email Request",
                        $"Confirm Changing your email to {profile.Email} by <a href='{HtmlEncoder.Default.Encode(url ?? "")}'>clicking here</a>.");
                }
                user.Firstname = profile.Firstname;
                user.Lastname = profile.Lastname;
                
                await _userManager.UpdateAsync(user);
                profile.IsChanged = true;
            }
            model.ProfileDetails.Firstname = user.Firstname;
            model.ProfileDetails.Lastname = user.Lastname;
            model.ProfileDetails.Email= user.Email;
            model.ProfileDetails.IsEmptyPassword = user.PasswordHash == null;

            return View(nameof(Settings), model);
        }

        [HttpGet]
        public async Task<IActionResult> Settings() 
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) 
            {
                return NotFound();
            }

            var model = new SettingsViewModel();
            model.ProfileDetails = new ProfileDetailsViewModel();
            model.ProfileDetails.Firstname = user.Firstname;
            model.ProfileDetails.IsEmptyPassword = user.PasswordHash == null;
            model.ProfileDetails.Email = user.Email;
            model.ProfileDetails.Lastname = user.Lastname;
            return View(model);
        }
		#endregion


		[HttpGet]
        public async Task<IActionResult> IndexAsync(int? page = 1)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) 
            {
                return NotFound();
            }
            	//Page
			if (page < 1) 
			{
				page = 1;
			}
            return View(await PaginatedList<Car>.CreateAsync(_favouritesService.GetUserFavourites(user.Id), page ?? 1, 2));
        } 
        
        [HttpGet]
        public IActionResult Accessdenied()
        {
            return View();
        }
    }
}

using CarRental.Application.Contracts;
using CarRental.Application.Helpers;
using CarRental.Data.Abstracts;
using CarRental.Data.Constants;
using CarRental.Data.DTO.Requests;
using CarRental.Data.Models;
using CarRental.Data.Models.Entities;
using CarRental.Data.Return;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CarRental.Application.Repositories
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly JwtOptions _jwtOptions;
        private readonly IEmailSender _emailSender;
        public AuthService(UserManager<User> userManager,
            IOptions<JwtOptions> jwtSettings,
            SignInManager<User> signInManager,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _jwtOptions = jwtSettings.Value;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }
        public async Task<IResult> ChangePassword(ChangePasswordDTO changePasswordDto)
        {
            var user = await _userManager.FindByIdAsync(changePasswordDto.UserId);
            if (user == null) 
            {
                return new ErrorResult(Messages.UserNotFound);
            }
            bool IsVaildPass = await _userManager.CheckPasswordAsync(user,changePasswordDto.OldPassword);

            if (!IsVaildPass) 
            {
                return new ErrorResult(Messages.WrongOldPassword);
            }
            var IdentityResult = await _userManager.RemovePasswordAsync(user);
            if (!IdentityResult.Succeeded) 
            {
                return new ErrorResult(Messages.ResetPasswordGeneric);
            }
            IdentityResult = await _userManager.AddPasswordAsync(user,changePasswordDto.NewPassword);
            if (!IdentityResult.Succeeded)
            {
                return new ErrorResult(Messages.CannotAddPassword);
            }
            return new SuccessResult(Messages.PasswordUpdated);

        }

        public async Task<IResult> ConfirmEmailAddress(ConfirmEmailDTO data)
        {
            var user = await _userManager.FindByIdAsync(data.userId);
            if (user == null) 
            {
                return new ErrorResult("User Was Not Found.");
            }
            if (user.EmailConfirmed) 
            {
                return new ErrorResult("Email Already Confirmed.");

            }
            if (user.EmailConfirmationToken != data.ConfirmCode || user.EmailConfirmationToken == null) 
            {
                return new ErrorResult("Invaild Code.");
            }
            user.EmailConfirmed = true;
            user.EmailConfirmationToken = null;

            await _userManager.UpdateAsync(user);
            return new SuccessResult("Email Confirmed.");
        }

        public async Task<string> GenerateToken(User user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var roles = await _userManager.GetRolesAsync(user);

            var roleClaims = new List<Claim>();

            for (int i = 0; i < roles.Count; i++)
            {
                roleClaims.Add(new Claim(ClaimTypes.Role, roles[i]));
            }

            var claims = new[]
			{  
                new Claim(ClaimTypes.NameIdentifier,user.Id),
				new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id),
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtOptions.Issuer,
                audience: _jwtOptions.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtOptions.DurationInMinutes),
                signingCredentials: signingCredentials);
            return new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
        }

        public async Task<IDataResult<User>> Login(UserLoginReq user)
        {
            var existingUser = await _userManager.FindByNameAsync(user.Email);
            if (existingUser == null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            var result = await _signInManager.PasswordSignInAsync(existingUser, user.Password, false,false);

            if (result.IsNotAllowed) 
            
            {
                return new ErrorDataResult<User>(existingUser, Messages.ConfirmEmail);

            }
            if (!result.Succeeded)
            {
                return new ErrorDataResult<User>(existingUser, Messages.BadCreds);
            }
            return new SuccessDataResult<User>(existingUser, Messages.SuccessfulLogin);
        }

        public async Task<IDataResult<User>> Register(UserRegistarDTO userForRegisterDto)
        {
            var user = new User
            {
                Email = userForRegisterDto.Email,
                UserName = userForRegisterDto.Email,
                Firstname = userForRegisterDto.FirstName,
                Lastname = userForRegisterDto.LastName,
                EmailConfirmed = false,
                EmailConfirmationToken = RandomHelper.GenerateConfirmationCode(8).ToString(),
                CreatedDate = DateTime.UtcNow,
            };
            var result = await _userManager.CreateAsync(user, userForRegisterDto.Password);

            
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, Roles.Customer);
                await _emailSender.SendEmailAsync(user.Email, "Confirm your email",
               $"Confirmation Code : {user.EmailConfirmationToken}");


                return new SuccessDataResult<User>(user, Messages.RegisterSuccess);
            }
            else
            {
                //var errors = result.Errors;
                //foreach (var error in errors) 
                //{
                //    if (error.Code == "PasswordRequiresUpper") 
                //    {
                //        return new ErrorDataResult<User>(user, error.Description);
                //    }else if (error.Code == "PasswordRequiresDigit") 
                //    {
                //        return new ErrorDataResult<User>(user, error.Description);

                //    }else if (error.Code == "PasswordRequiresNonAlphanumeric") 
                //    {
                //        return new ErrorDataResult<User>(user, error.Description);

                //    }
                //}
                return new ErrorDataResult<User>(user, Messages.RegisterFail);
                //throw new Exception($"{result.Errors}");
            }
        }

        public async Task<IResult> ResetPassword(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null) 
            {
                return new SuccessResult(Messages.ResetPassword);
            }
            user.ResetPasswordToken = RandomHelper.GenerateConfirmationCode(8).ToString();
            user.ResetPasswordExpires = DateTime.UtcNow.AddMinutes(5);

            await _emailSender.SendEmailAsync(user.Email, "Reset Your Password",
          $"Confirmation Code : {user.ResetPasswordToken}");
            await _userManager.UpdateAsync(user);
            return new SuccessResult(Messages.ResetPassword);
        }

        public async Task<IResult> ResetPassword(ResetPasswordRequest data)
        {
            var user = await _userManager.FindByEmailAsync(data.Email);
            if (user == null) 
            {
                return new ErrorResult(Messages.InvailedResetCode);
            }
            if (data.RestToken != user.ResetPasswordToken || user.ResetPasswordToken == null) 
            {
                return new ErrorResult(Messages.InvailedResetCode);
            }
            if (DateTime.UtcNow >= user.ResetPasswordExpires) 
            {
                return new ErrorResult(Messages.ResetCodeExpired);
            }

            var IdentityResult = await _userManager.RemovePasswordAsync(user);
            if (!IdentityResult.Succeeded)
            {
                return new ErrorResult(Messages.ResetPasswordGeneric);
            }

            IdentityResult = await _userManager.AddPasswordAsync(user, data.Password);
            if (!IdentityResult.Succeeded)
            {
                return new ErrorResult(Messages.CannotAddPassword);
            }
            return new SuccessResult(Messages.PasswordUpdated);

        }

        public async Task<IResult> UserExists(string email)
        {

            if (await _userManager.FindByNameAsync(email) != null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}

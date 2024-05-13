//using CarRental.Application.Contracts;
//using CarRental.Data.DTO;
//using CarRental.Data.Models;
//using CarRental.Data.Return;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using IResult = CarRental.Data.Abstracts.IResult;

//namespace CarRental.API.Controllers
//{
//	[ApiController]
//    [Route("[controller]")]
//    public class AuthController : ControllerBase
//    {
//        private readonly IAuthService _authService;
//        public AuthController(
//            IAuthService authService
//            )
//        {
//            _authService = authService;


//        }
//        [HttpPost("login")]
//        public async Task<IResult> Login(UserLoginReqDTO userForLoginDto)
//        {
//            var userToLogin =  await _authService.Login(userForLoginDto);
//            if (!userToLogin.Success)
//            {
//                return new ErrorResult(userToLogin.Message);
//            }
//            return new SuccessDataResult<JWTAccessToken>(new JWTAccessToken(await _authService.GenerateToken(userToLogin.Data)), "Logged in successfully.");
//        }

//        [HttpPost("register")]
//        public async Task<IResult> RegisterAsync(UserRegistarDTO userForRegisterDto)
//        {
//            var userExists = await _authService.UserExists(userForRegisterDto.Email);
//            if (!userExists.Success)
//            {
//                return userExists;
//            }
//            var registerResult = await _authService.Register(userForRegisterDto);
//            if (!registerResult.Success)
//            {
//                return new ErrorResult(registerResult.Message);
//            }
//            return new SuccessDataResult<RegisterResponse>(new RegisterResponse() { UserId = registerResult.Data.Id },"User Registered Successfully.");
//        }

//        [HttpPost("change-password")]
       
//        public async Task<IActionResult> ChangePasswordAsync(ChangePasswordDTO changePasswordDto)
//        {
//            var result = await _authService.ChangePassword(changePasswordDto);
//            if (result.Success)
//            {
//                return Ok(result);
//            }
//            return BadRequest(result);
//        }



//        [HttpPost("confirm-email")]
//        public async Task<IResult> ConfirmEmail(ConfirmEmailDTO data) 
//        {
//            var result = await _authService.ConfirmEmailAddress(data);
//            return result;
//        }

//        [HttpPost("forget-password")]
//        public async Task<IResult> ResetPassword(string email)
//        {
//            var result = await _authService.ResetPassword(email);
//            return result;
//        }

//        [HttpPost("reset-password")]
//        public async Task<IResult> ResetPassword(ResetPasswordRequest data)
//        {
//            var result = await _authService.ResetPassword(data);
//            return result;
//        }


//        [HttpGet("A"),Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
//        public string GetAsyn() 
//        {
//            return "Worked !";
//        }
//    }
//}
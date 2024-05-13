using AutoMapper;
using CarRental.Application.Contracts;
using CarRental.Data.Constants;
using CarRental.Data.DTO.Entities;
using CarRental.Data.DTO.Requests;
using CarRental.Data.DTO.Responses;
using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = Roles.Administrator, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

    public class AdminController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
		public AdminController(
			IAuthService authService
, UserManager<User> userManager,
IMapper mapper)
		{
			_authService = authService;
			_userManager = userManager;
			_mapper = mapper;
		}


		[HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginReq userForLoginDto)
        {
            var loginResult = await _authService.Login(userForLoginDto);
            if (!loginResult.Success)
            {
                return NotFound();
            }
            var userRoles = await _userManager.GetRolesAsync(loginResult.Data);
            var IsAdmin = userRoles.Contains(Roles.Administrator);

			if (IsAdmin || userRoles.Contains(Roles.Branch))
            {
                string token = await _authService.GenerateToken(loginResult.Data);
                var res = new LoginResponse { Token = token ,IsAdmin = IsAdmin, User = _mapper.Map<UserDto>(loginResult.Data)};
                return Ok(res);
			}
            return NotFound();
        }



    }
}

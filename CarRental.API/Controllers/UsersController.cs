using AutoMapper;
using CarRental.Application.Contracts.Entities;
using CarRental.Data.Constants;
using CarRental.Data.DTO.Entities;
using CarRental.Data.DTO.Requests;
using CarRental.Data.DTO.Responses;
using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CarRental.Data.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
	[Authorize(Roles = Roles.Administrator, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

	public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
		private readonly UserManager<User> _userManager;
		private readonly IBranchService _branchService;
		private readonly IMapper _mapper;
		private readonly IRentalService _rentalService;
		private readonly ICarService _carService;
        private readonly IBrandService _brandService;


        public UsersController(IUserService userService, IBranchService branchService, UserManager<User> userManager, IMapper mapper, IRentalService rentalService, ICarService carService, IBrandService brandService)
        {
            _userService = userService;
            _branchService = branchService;
            _userManager = userManager;
            _mapper = mapper;
            _rentalService = rentalService;
            _carService = carService;
            _brandService = brandService;
        }


        [HttpGet("Search"), Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<List<UserDto>> GetUsersAsync(string? email, string? first, string? last, string? City, string? Phone) 
        {
            return _mapper.Map<List<UserDto>>(await _userService.GetUsers(email, first, last, City, Phone));
        }
		[HttpPost("AddBranchUser")]
		public async Task<IActionResult> AddBranchUser(AddUserBranchReq req)
		{

			var user = await _userManager.FindByIdAsync(req.UserId);
			if (user == null)
			{
				return NotFound();
			}

			if (await _userManager.IsInRoleAsync(user, Roles.Administrator))
			{
				return Ok();
			}

			var branch = await _branchService.Get(req.BranchId);
			if (branch == null)
			{
				return NotFound();
			}
			user.BranchId = branch.Id;
			await _userManager.UpdateAsync(user);
			if (await _userManager.IsInRoleAsync(user,Roles.Branch)) 
			{
				return Ok();
			}
			await _userManager.AddToRoleAsync(user,Roles.Branch);
			return Ok();
		}

        [HttpDelete("DeleteBranchUser")]

        public async Task<IActionResult> DeleteBranchUser(string UserId) 
		{
            var user = await _userManager.FindByIdAsync(UserId);
            if (user == null)
            {
                return NotFound();
            }
			if (user.BranchId  != null) 
			{
				user.BranchId = null;
                await _userManager.UpdateAsync(user);
            }
			return Ok();
        }



        [HttpPost("Statistics")]
        public async Task<IActionResult> GetStatistics(StatisticsRequest req)
        {
            if (ModelState.IsValid)
            {

                var res = new StatisticsResponse();
                var RentalsQuery = _rentalService.AsQueryable()
                    .Where(x => x.RentDate >= req.From && x.RentDate <= req.To);
                var CarQuery = _carService.AsQueryable();
                if (!User.IsInRole(Roles.Administrator))
                {
                    var user = await _userManager.GetUserAsync(User);

                    if (user == null)
                    {
                        return NotFound();
                    }

                    if (user.BranchId == null)
                    {
                        return NotFound();
                    }

                    RentalsQuery = RentalsQuery.Where(x => x.BranchId == user.BranchId);
                    CarQuery = CarQuery.Where(x=>x.BranchId == user.BranchId);
                }

                res.TotalRentals = await RentalsQuery
                       .CountAsync();

                res.TotalPendingRentals = await RentalsQuery.Where(x => x.Status == RentalStatus.Processed )
                    .CountAsync();

                res.TotalRejectedRentals = await RentalsQuery.Where(x => x.Status == RentalStatus.Rejected
                || x.Status == RentalStatus.Cancelled)
                 .CountAsync();

                res.TotalCompletedRentals = await RentalsQuery.Where(x => x.Status == RentalStatus.Returned)
                 .CountAsync();

                res.TotalRevenue = await RentalsQuery.SumAsync(x => x.Payment.TotalPrice);

                res.TotalPendingRevenue = await RentalsQuery.Where(x => x.Status == RentalStatus.Processed)
                .SumAsync(x => x.Payment.TotalPrice);


                res.TotalRejectedRevenue = await RentalsQuery.Where(x => x.Status == RentalStatus.Rejected || x.Status == RentalStatus.Cancelled)
              .SumAsync(x => x.Payment.TotalPrice);

                res.TotalCompletedRevenue = await RentalsQuery.Where(x => x.Status == RentalStatus.Returned)
              .SumAsync(x => x.Payment.TotalPrice);



                res.Cars = await CarQuery.CountAsync();
                res.Branches = await _branchService.AsQueryable().CountAsync();
                res.Brands = await _brandService.AsQueryable().CountAsync();
                res.Users = await _userService.AsQueryable().CountAsync();

                return Ok(res);

            }
            return NotFound();
        }
    }
}

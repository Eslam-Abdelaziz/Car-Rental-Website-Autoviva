using AutoMapper;
using CarRental.Application.Contracts.Entities;
using CarRental.Data.Abstracts;
using CarRental.Data.Constants;
using CarRental.Data.DTO.Entities;
using CarRental.Data.DTO.Requests;
using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	[Authorize(Roles = Roles.AdminRoles, AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]

	public class RentalsController : ControllerBase
	{

		private readonly IRentalService _rentalService;
		private readonly IPaymentService _paymentService;

		private readonly IMapper _mapper;
		private readonly UserManager<User> _userManager;

        public RentalsController(IRentalService rentalService, IMapper mapper, UserManager<User> userManager, IPaymentService paymentService)
        {
            _rentalService = rentalService;
            _mapper = mapper;
            _userManager = userManager;
            _paymentService = paymentService;
        }

        // GET: api/<Rental>
        [HttpPost("Search")]
        public async Task<IActionResult> Search(RentalSearchRequest req)
        {
            if (req == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var query = _rentalService.AsQueryable()
              .Include(x => x.Car)
              .Include(x => x.User)
              .Include(x => x.Payment)
              .Include(x => x.ReturnBranch)
              .Include(x => x.Car.Branch)
              .Include(x => x.Car.Color)
              .Include(x => x.Car.CarImages)
              .Include(x => x.Car.Brand)
              .AsQueryable();

            if (req.From < req.To)
            {
                query = query.Where(x => x.RentDate >= req.From && x.RentDate <= req.To);
            }

            if (req.Username != null)
            {
                query = query.Where(x => x.User.Firstname.Contains(req.Username) || x.User.Lastname.Contains(req.Username));
            }
            query = query.Where(x => x.Payment.TotalPrice >= req.Price);

            if (req.Email != null)
            {
                query = query.Where(x => x.User.Email.Contains(req.Email));
            }
            if (req.RentalStatus != null)
            {
                query = query.Where(x => x.Status == (RentalStatus)req.RentalStatus);
            }
            if (User.IsInRole(Roles.Administrator))
            {
                return Ok(_mapper.Map<List<RentalDto>>(await query.Take(100).ToListAsync()));
            }

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound();
            }

            if (user.BranchId == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<RentalDto>>(query.Where(x => x.BranchId == user.BranchId)
                .Take(100).ToListAsync()));
        }

        [HttpGet("Total")]
		public async Task<IActionResult> TotalAsync() 
		{
            var query = _rentalService.AsQueryable();

            if (User.IsInRole(Roles.Administrator))
            {
                return Ok(await query.CountAsync());
            }
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return NotFound();
            }

            if (user.BranchId == null)
            {
                return NotFound();
            }
            return Ok(await query.Where(x=>x.BranchId == user.BranchId).CountAsync());
		}
        // GET api/<Rental>/5
        [HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var rental = await _rentalService.Get(id);
			if (rental == null) 
			{
				return NotFound();
			}
			return Ok(_mapper.Map<RentalDto>(rental));
		}

		// PUT api/<Rental>/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutAsync(int id, EditRentalReq req)
		{
            var rental = await _rentalService.GetRentalAsync(id);
            if (rental == null)
            {
                return NotFound();
            }
			rental.Status = req.RentalStatus;

            var payment = await _paymentService.Get(rental.Payment.Id);
            if (payment == null) 
            {
                return NotFound();
            }
            payment.Status = req.PaymentStatus;
            await _paymentService.Update(payment);
            await _rentalService.Update(rental);
			return Ok();
        }
	}
}

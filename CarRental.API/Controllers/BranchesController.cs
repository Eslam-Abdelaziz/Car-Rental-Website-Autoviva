using AutoMapper;
using CarRental.Application.Contracts.Entities;
using CarRental.Data.Constants;
using CarRental.Data.DTO.Entities;
using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = Roles.AdminRoles,AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BranchesController : ControllerBase
    {
        private readonly IBranchService _branchService;
        private readonly IMapper _mapper;
		private readonly UserManager<User> _userManager;

		public BranchesController(IBranchService branchService, IMapper mapper, UserManager<User> userManager)
		{
			_branchService = branchService;
			_mapper = mapper;
			_userManager = userManager;
		}

		// GET: api/<BranchesController>
		[HttpGet]
        public async Task<IActionResult> Get()
        {
            if (User.IsInRole(Roles.Administrator)) 
            {
				return Ok(_mapper.Map<IList<BranchDto>>(await _branchService.GetBranches()));

			}
			if (User.IsInRole(Roles.Branch)) 
            {
                var user =  await _userManager.GetUserAsync(User);
                if(user == null) 
                {
                    return NotFound();
                }
                if (user.BranchId == null) 
                {
                    return NotFound();
                }
                var branch = _mapper.Map<BranchDto>(await _branchService.GetBranch(user.BranchId.Value));

				return Ok(new List<BranchDto>() { branch });
            }
            return NotFound();
        }

        // GET api/<BranchesController>/5
        [HttpGet("{id}")]
        public async Task<BranchDto?> Get(int id)
        {
            return _mapper.Map<BranchDto>(await _branchService.Get(id));
        }

        // POST api/<BranchesController>
        [HttpPost]
        public async Task<IActionResult> Post(BranchDto branch)
        {
            await _branchService.Add(_mapper.Map<Branch>(branch));
            return Ok();
        }

        // PUT api/<BranchesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, BranchDto branch)
        {
            var b = await _branchService.GetBranch(id);
            if(b == null) 
            {
                return NotFound();
            }
            //Update Address
            b.Address.State = branch.Address.State;
            b.Address.City = branch.Address.City;
            b.Address.Street = branch.Address.Street;
            b.Address.Phone = branch.Address.Phone;
            b.Address.ZipCode = branch.Address.ZipCode;

            //Update Name
            b.Name = branch.Name;

            await _branchService.Update(b);
            return Ok();
        }
        
    }
}

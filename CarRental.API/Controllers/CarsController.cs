using AutoMapper;
using CarRental.Application.Contracts.Entities;
using CarRental.Data.Constants;
using CarRental.Data.DTO;
using CarRental.Data.DTO.Entities;
using CarRental.Data.DTO.Requests;
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

    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly IMapper _mapper;
        private readonly ICarImageService _carImageService;
		private readonly UserManager<User> _userManager;
		public CarsController(ICarService carService, IMapper mapper, ICarImageService carImageService, UserManager<User> userManager)
		{
			_carService = carService;
			_mapper = mapper;
			_carImageService = carImageService;
			_userManager = userManager;
		}
        [HttpGet("Total")]
        public async Task<IActionResult> GetTotal()
		{
			if (User.IsInRole(Roles.Administrator))
			{
				return Ok(await _carService.TotalCars(null));
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
			return Ok(await _carService.TotalCars(user.BranchId));
		}

		// GET: api/<CarsController>
		[HttpGet]
		public async Task<IActionResult> Get(string? name, int? modelyear, int? brandid, int? branchid, int? colorid, int? size, int? seats, double? price, bool? isElectric,bool? IsAutomatic)
		{
            if (User.IsInRole(Roles.Administrator)) 
            {
				return Ok(_mapper.Map<IList<CarDto>>(await _carService.GetCars(name, modelyear, brandid, branchid, colorid, size, seats, price, isElectric, IsAutomatic)));
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
			return Ok(_mapper.Map<IList<CarDto>>(await _carService.GetCars(name, modelyear, brandid, user.BranchId, colorid, size, seats, price, isElectric, IsAutomatic)));
		}

		// GET api/<CarsController>/5
		[HttpGet("{id}")]
        public async Task<CarDto?> GetAsync(int id)
        {
            return _mapper.Map<CarDto>(await _carService.Get(id));
        }
        // POST api/<CarsController>
        [HttpPost]
        public async Task<IActionResult> Post(CarCreateRequest req)
        {
			return Ok(_mapper.Map<CarDto>(await _carService.Add(_mapper.Map<Car>(req))));
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsync(int id, CarEditRequest req)
        {
            await _carService.Update(_mapper.Map<Car>(req));
            return Ok();
        }
		[HttpPost("{id}/Images")]
		public async Task<IActionResult> PostCarImages(int id,IFormFileCollection files , bool delete) 
        {
			var car = await _carService.GetCar(id);
			if (car == null)
			{
				return NotFound();
			}
            if(files == null) 
            {
                return BadRequest();
            }
            if (delete) 
            {
                await _carImageService.DeleteImagesAsync(car.CarImages);
            }
            await _carImageService.AddImagesAsync(car.Id,files);
            return Ok();
		}

		[HttpGet("{id}/Images")]
		public async Task<IActionResult> GetCarImages(int id) 
        {
			var car = await _carService.GetCar(id);
			if (car == null) 
            {
                return NotFound();
            }
            if (car.CarImages == null) 
            {
                return NotFound();
            }
            return Ok(_mapper.Map<List<CarImageDto>>(car.CarImages));
		}

		[HttpGet("{id}/{imageid}")]
        public async Task<IActionResult> GetCarImage(int id ,int imageid)
        {
            var car = await _carService.GetCar(id);
            if (car == null) 
            {
                return NotFound();
            }
            return await _carImageService.GetCarImage(car,imageid);
        }
    }
}

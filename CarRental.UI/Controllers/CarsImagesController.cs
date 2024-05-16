using CarRental.Application.Contracts.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.UI.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class CarsImagesController : ControllerBase
	{
		private readonly ICarService _carService;
		private readonly ICarImageService _carImageService;

		public CarsImagesController(ICarImageService carImageService, ICarService carService)
		{
			_carImageService = carImageService;
			_carService = carService;
		}

		[HttpGet("{id}/{imageid}")]
		public async Task<IActionResult> CarImage(int id, int imageid)
		{
			if (imageid < 1)
			{
				return NotFound();
			}
			imageid--;

            if (ModelState.IsValid)
			{
				var car = await _carService.GetCar(id);
				if (car == null)
				{
					return NotFound();
				}
				if (car.CarImages.Count > imageid)
				{
					return await _carImageService.ImageToResult(car.CarImages[imageid]);
				}
			}
			return NotFound();

		}
	}
}

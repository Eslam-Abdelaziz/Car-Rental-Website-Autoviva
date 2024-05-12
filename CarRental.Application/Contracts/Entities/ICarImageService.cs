using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace CarRental.Application.Contracts.Entities
{
	public interface ICarImageService : IGenericRepository<CarImage>
	{
		Task DeleteImagesAsync(IEnumerable<CarImage> imgs);
		Task AddImagesAsync(int carid, IFormFileCollection files);
		Task<IActionResult> GetCarImage(Car car, int imageid);
		Task<IActionResult> ImageToResult(CarImage img);
	}
}

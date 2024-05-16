using CarRental.Data.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.UI.ViewComponents
{

	public class CarViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(Car model)
		{
			return View(model);
		}
	}
}

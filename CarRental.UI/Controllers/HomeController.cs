using CarRental.Application.Contracts.Entities;
using CarRental.Data.Models.Entities;
using CarRental.UI.Models.Home;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CarRental.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IBranchService _branchService;
        private readonly IModelService _modelService;
        private readonly ICarService _carService;
        private readonly UserManager<User> _userManager;
        private readonly IFavouritesService _favouritesService;

        public HomeController(IBrandService brandService, IBranchService branchService, IModelService modelService, ICarService carService, UserManager<User> userManager, IFavouritesService favouritesService)
        {
            _brandService = brandService;
            _branchService = branchService;
            _modelService = modelService;
            _carService = carService;
            _userManager = userManager;
            _favouritesService = favouritesService;
        }

        [HttpGet] 
        public async Task<IActionResult> Models(int id) 
        {
            if (ModelState.IsValid) 
            {
                var brand = await  _brandService.Get(id);
                if (brand == null) 
                {
                    return NotFound();
                }
                return Ok(await _modelService.AsQueryable().Where(x => x.BrandId == id).ToArrayAsync());
            }
            return NotFound();
        }

        public async Task<IActionResult> Index()
        {

            if (TempData["RentMsg"] != null)
            {
                ViewBag.RentMsg = TempData["RentMsg"];
            }
            var brands = await _brandService.GetAll();
            var branches = await _branchService.GetAll();
            var years = await _carService.AsQueryable().Select(x=>x.ModelYear).ToListAsync();
            var featuredCars = _carService.AsQueryable().OrderByDescending(c => c.FindexScore).Take(6);
            var user = await _userManager.GetUserAsync(User);
            if(user != null) 
            {
                var Favids = _favouritesService.GetUserFavourites(user.Id).Select(x=>x.Id).ToHashSet();
                foreach (var item in featuredCars)
                {
                    if (Favids.Contains(item.Id)) 
                    {
                        item.IsFavourite = true;
                    }
                }
            }  
            var viewModel = new HomeViewModel()
            {
                Brands = brands,
                Branches = branches,
                Years = years.DistinctBy(x=>x),
                FeaturedCars = featuredCars
            };
            return View(viewModel);
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult About() 
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Faq()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using CarRental.Application.Contracts.Entities;
using CarRental.Data.Models.Entities;
using CarRental.UI.Models;
using CarRental.UI.Models.Cars;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe;
using Stripe.Checkout;
using System.Net;
using System.Text.Json;

namespace CarRental.UI.Controllers
{

	public class CarsController : Controller
    {
        private readonly ICarService _carService;
		private readonly IBrandService _brandService;
		private readonly UserManager<User> _userManager;
		private readonly IFavouritesService _favouritesService;
		private readonly IBranchService _branchService;
        private readonly IRentalService _rentalService;
        private readonly IPaymentService _paymentService;

        private static string cookieName = "Rental";

        public CarsController(ICarService carService, IBrandService brandService, UserManager<User> userManager, IFavouritesService favouritesService, IBranchService branchService, IRentalService rentalService, IPaymentService paymentService)
        {
            _carService = carService;
            _brandService = brandService;
            _userManager = userManager;
            _favouritesService = favouritesService;
            _branchService = branchService;
            _rentalService = rentalService;
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<IActionResult> SearchAsync(IndexCarSearchReq req, int? page = 1) 
		{
            var errors = ModelState.ToArray();
			if (ModelState.IsValid) 
			{

                var carSeats = await _carService.AsQueryable().Select(x => x.Seats).Distinct().ToListAsync();


                var cars = _carService.GetAllCars().Include(x=>x.Model).AsQueryable();

                ViewBag.Keyword = req.Keyword;
                ViewBag.Sort = req.Sort;
                ViewBag.Brand = req.Brand;
                ViewBag.Gasoline = req.Gasoline;
                ViewBag.Eletric = req.Eletric;

                //Page
                if (page < 1)
                {
                    page = 1;
                }

                //keyword
                if (req.Keyword != null)
                {
                    cars = cars.Where(car => car.Name.Contains(req.Keyword));
                }
                if (req.MinPrice != null)
                {
                    cars = cars.Where(car => car.DailyPrice >= req.MinPrice);
                }

                if (req.MaxPrice != null)
                {
                    cars = cars.Where(car => car.DailyPrice <= req.MaxPrice);
                }


                if (req.MinYear != null)
                {
                    cars = cars.Where(car => car.ModelYear >= req.MinYear);
                }
                if (req.MaxYear != null)
                {
                    cars = cars.Where(car => car.ModelYear <= req.MaxPrice);
                }

                if (req.Model != null  )
                {
                    cars = cars.Where(car => car.Model.Name == req.Model);
                }

                cars = cars.Where(car => car.Branch.Name == req.RentBranch);

                var cookie = GetRentalFromCookies();
                if (cookie != null)
                {
                    var unavailableCars = _rentalService.AsQueryable().Where(x => cookie.From >= x.RentDate || x.ReturnDate <= cookie.ReturnDate)
                     .Where(x => x.Status != Data.Abstracts.RentalStatus.Cancelled || x.Status != Data.Abstracts.RentalStatus.Returned)
                     .Select(x => x.CarId).ToHashSet();
                    cars = cars.Where(x => !unavailableCars.Contains(x.Id));
                }
                //brand 
                if (req.Brand != null)
                {
                    cars = cars.Where(car => car.Brand.Name == req.Brand);

                }

                if ((req.Eletric != null && req.Gasoline != null) || (req.Eletric == null && req.Gasoline == null))
                {
                    //don't do any
                }
                else if (req.Gasoline == null)
                {
                    cars = cars.Where(car => car.IsElectric);
                }
                else
                {
                    cars = cars.Where(car => !car.IsElectric);

                }
                //Sort
                if (req.Sort != null)
                {
                    if (req.Sort == 1)
                    {
                        cars = cars.OrderByDescending(car => car.ModelYear);
                    }
                    else if (req.Sort == 2)
                    {
                        cars = cars.OrderBy(car => car.ModelYear);
                    }
                }

              

                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    ViewBag.FavIds = _favouritesService.GetUserFavourites(user.Id).Select(f => f.Id).ToHashSet();
                }
                if (await cars.CountAsync() > 0) 
                {
                    AddRentIntoCookies(req);
                }
                ViewBag.Brands = await _brandService.GetAll();
                ViewBag.Seats = carSeats;

                return View(nameof(Index), await PaginatedList<Car>.CreateAsync(cars, page ?? 1, 4));
            }
            return NotFound();
        }

        private void AddRentIntoCookies(IndexCarSearchReq req)
        {
            Response.Cookies.Append(cookieName,JsonSerializer.Serialize(req));
		}
        private IndexCarSearchReq? GetRentalFromCookies() 
        {
            if (Request.Cookies.ContainsKey(cookieName))
            {
                var str = Request.Cookies[cookieName]?.ToString();
                return JsonSerializer.Deserialize<IndexCarSearchReq>(str ?? "");
            }
            return null;
        }

        [HttpGet("Cars/Car/{id}")]
        public async Task<IActionResult> CarAsync(int id) 
        {

            if (ModelState.IsValid) 
            {
                var car = await _carService.GetCar(id);
                if (car == null) 
                {
                    return NotFound();
                }


                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    bool isFav =  _favouritesService.GetUserFavourites(user.Id).Select(f=>f.Id).Contains(car.Id);
                    if (isFav) 
                    {
                        car.IsFavourite = true;
                    }
                }
                await _carService.AddFindexScore(car,0.5);
                ViewBag.Request = GetRentalFromCookies();
                ViewBag.FeatureCars = _carService.AsQueryable().Where(c=>c.Id != car.Id).Take(6).OrderByDescending(c => c.FindexScore);
                return View(car);
            }
            return NotFound();
        }

        public async Task<Session> GetSessionForCar(Car car , IndexCarSearchReq req) 
        {
            var days = (req.ReturnDate - req.From).Days;
            var domain = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {
                   new ()
                   {
                       PriceData = new SessionLineItemPriceDataOptions()
                       {
                          UnitAmount = (long)(car.DailyPrice * days *100),
                          Currency = "EGP",
                          ProductData = new SessionLineItemPriceDataProductDataOptions()
                          {
                              Name = car.Name,
                          },

                       },
                       Quantity = 1,
                   },
                },
                Mode = "payment",
                SuccessUrl = $"{domain}/checkout/success?sessionId=" + "{CHECKOUT_SESSION_ID}", // Customer paid.
                CancelUrl  =  $"{domain}/checkout/failed?sessionId=" + "{CHECKOUT_SESSION_ID}", // Customer paid.
            };
            var service = new SessionService();
            return await service.CreateAsync(options);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> RentCar(int Carid,int PaymentType) 
        {
            if (ModelState.IsValid) 
            {

                var user = await _userManager.GetUserAsync(User);
                if (user != null) 
                {
                    var car = await _carService.GetCar(Carid);
                    if (car != null)
                    {
                        var Req = GetRentalFromCookies();
                        if (Req == null)
                        {
                            TempData["RentMsg"] = "Please Select Rent Date & Return Date";
                        }
                        else
                        {
                            var ReturnBranch = car.Branch;
                            if (Req.ReturnBranch != car.Branch.Name && Req.ReturnBranch != null)
                            {
                                ReturnBranch = await _branchService.AsQueryable().FirstOrDefaultAsync(b => b.Name == Req.ReturnBranch);
                                if (ReturnBranch == null)
                                {
                                    TempData["RentMsg"] = "Error Occured Please Select another Return Branch";
                                }
                            }
                            if (ReturnBranch != null)
                            {


                                var Days = (Req.ReturnDate - Req.From).Days;
                                var TotalPrice = car.DailyPrice * Days;
                                var rental = new Rental()
                                {
                                    RentDate = Req.From,
                                    ReturnDate = Req.ReturnDate,
                                    CarId = Carid,
                                    BranchId = ReturnBranch.Id,
                                    UserId = user.Id,
                                    Status = Data.Abstracts.RentalStatus.Processed
                                };

                                rental = await _rentalService.Add(rental);

                                await _carService.AddFindexScore(car,1);
                                var payment = new Payment { 
                                    RentalId = rental.Id ,
                                    TotalPrice = TotalPrice,
                                    Status = Data.Abstracts.PaymentStatus.NotPaid
                                };
                                Session session  = new Session();
                                Response.Cookies.Delete(cookieName);
                                if (PaymentType == 1) 
                                {
                                    payment.Type = Data.Abstracts.PaymentType.CashOnDelivery;
                                    payment = await _paymentService.Add(payment);
                                    return LocalRedirect($"/Rentals/{rental.Id}");
                                }
                                else  
                                {
                                    session = await GetSessionForCar(car, Req);
                                    payment.Type = Data.Abstracts.PaymentType.CreditCard;
                                    payment.Session = session.Id;
                                    payment = await _paymentService.Add(payment);
                                    return Redirect(session.Url);


                                }

                            }

                        }
                    }
                }
                else 
                {
                    TempData["RentMsg"] = "Please Sign in First before Renting a Car";

                }

            }
            return LocalRedirect("/Home");
        }

        [HttpGet("Rentals/{Id}")]
        public async Task<IActionResult> Order(int Id) 
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null) 
            {
                bool ret = await _rentalService.
                             AsQueryable().Include(x=>x.Payment).Where(x => x.UserId == user.Id).Select(x => x.Id).ContainsAsync(Id);
                if (ret)
                {
                    return View(await _rentalService.GetRentalAsync(Id));
                }
            }
            return LocalRedirect("/Home");

        }

        [HttpGet("Rentals/Delete/{Id}")]
        public async Task<IActionResult> DeleteRental(int Id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                bool ret = await _rentalService.
                             AsQueryable().Include(x => x.Payment).Where(x => x.UserId == user.Id).Select(x => x.Id).ContainsAsync(Id);
                var rental = await _rentalService.GetRentalAsync(Id);
                if (ret && rental != null)
                {
                    if (rental.Status == Data.Abstracts.RentalStatus.Processed || rental.Status == Data.Abstracts.RentalStatus.Confirmed) 
                    {
                        rental.Status = Data.Abstracts.RentalStatus.Cancelled;
                        await _rentalService.Update(rental);
                        TempData["RentalMsg"] = "Rental Cancelled.";
                    }
                    if (rental.Payment.Status == Data.Abstracts.PaymentStatus.Paid
                        && rental.Payment.Type == Data.Abstracts.PaymentType.CreditCard) 
                    {
                        var refundOptions = new RefundCreateOptions
                        {
                            PaymentIntent = rental.Payment.StripePayment
                        };

                        try
                        {
                            var refundService = new RefundService();
                            var refund = refundService.Create(refundOptions);
                            if (refund.Status == "succeeded")
                            {
                                rental.Payment.Status = Data.Abstracts.PaymentStatus.Refunded;
                                await _paymentService.Update(rental.Payment);
                                TempData["RentalMsg"] = $"Refund of {refund.Amount / 100} EGP Has Been Issued to your card";
                                // Refund was successful
                                // Perform any additional actions
                                return RedirectToAction("Rentals", "Account");
                            }
                        
                        }
                        catch (Exception)
                        {
                            TempData["RentalError"] = "Error Occured when Issuing the refund please contact us.";
                            // Refund failed
                            // Handle the failure scenario
                            return RedirectToAction("Error", "Home");
                        }
                        
                    }

                    return RedirectToAction("Rentals", "Account");

                }
            }
            TempData["RentalError"] = "Error Ocurred When Cancelling Rental";
            return RedirectToAction("Rentals", "Account");

        }
        [HttpGet]
		public async Task<IActionResult> AddFavourite(int id)
		{
			var user = await _userManager.GetUserAsync(User);
			if (user == null)
			{
				return NotFound();
			}
			var car = await _carService.Get(id);
			if (car == null) 
			{
				return NotFound();
			}
			var fav = new Favourite()
			{
				UserId = user.Id,
				CarId = car.Id,
			};
            var result = await _favouritesService.AddRemoveFavourite(fav);

            //Add Findex Score or Delete
            await _carService.AddFindexScore(car, result ? 0.75 : -0.75);

            return Ok(result ? "add" : "del" );
		}

        [HttpGet]
        public async Task<IActionResult> IndexAsync(CarSearchReq req, int? page = 1)
        {
            var cars = _carService.GetAllCars();

            ViewBag.Keyword = req.Keyword;
            ViewBag.Sort = req.Sort;
            ViewBag.Brand = req.Brand;
            ViewBag.Gasoline = req.Gasoline;
            ViewBag.Eletric = req.Eletric;

            var carSeats = await _carService.AsQueryable().Select(x => x.Seats).Distinct().ToListAsync();


            //Page
            if (page < 1)
            {
                page = 1;
            }

            //keyword
            if (req.Keyword != null)
            {
                cars = cars.Where(car => car.Name.Contains(req.Keyword));
            }
            //brand 
            if (req.Brand != null)
            {
                if (req.Brand != 0)
                {
                    cars = cars.Where(car => car.BrandId == req.Brand);
                }
            }

            if ((req.Eletric != null && req.Gasoline != null) || (req.Eletric == null && req.Gasoline == null))
            {
                //don't do any
            }
            else if (req.Gasoline == null)
            {
                cars = cars.Where(car => car.IsElectric);
            }
            else
            {
                cars = cars.Where(car => !car.IsElectric);

            }


            if ((req.Manual != null && req.Automatic != null) || (req.Manual == null && req.Automatic == null))
            {
                //don't do any
            }
            else if (req.Manual == null)
            {
                cars = cars.Where(car => car.IsAutomatic);
            }
            else
            {
                cars = cars.Where(car => !car.IsAutomatic);

            }
            if (req.Seats != null && req.Seats != 0)
            {
                cars = cars.Where(x => x.Seats == req.Seats);
            }

            var cookie = GetRentalFromCookies();
            if (cookie != null)
            {
                var unavailableCars = _rentalService.AsQueryable().Where(x => cookie.From >= x.RentDate || x.ReturnDate <= cookie.ReturnDate)
                    .Where(x => x.Status != Data.Abstracts.RentalStatus.Cancelled || x.Status != Data.Abstracts.RentalStatus.Returned)
                    .Select(x => x.CarId).ToHashSet();
                cars = cars.Where(x => !unavailableCars.Contains(x.Id));


                if (cookie.MinPrice != null)
                {
                    cars = cars.Where(car => car.DailyPrice >= cookie.MinPrice);
                }
                if (cookie.MaxPrice != null)
                {
                    cars = cars.Where(car => car.DailyPrice <= cookie.MaxPrice);
                }
                if (cookie.MinYear != null)
                {
                    cars = cars.Where(car => car.ModelYear >= cookie.MinYear);
                }
                if (cookie.MaxYear != null)
                {
                    cars = cars.Where(car => car.ModelYear <= cookie.MaxPrice);
                }
                if (cookie.Model != null)
                {
                    cars = cars.Where(car => car.Model.Name == cookie.Model);
                }
                cars = cars.Where(car => car.Branch.Name == cookie.RentBranch);
            }
            //Sort
            if (req.Sort != null)
                {
                    if (req.Sort == 1)
                    {
                        cars = cars.OrderByDescending(car => car.ModelYear);
                    }
                    else if (req.Sort == 2)
                    {
                        cars = cars.OrderBy(car => car.ModelYear);
                    }
                }
                else
                {
                    cars = cars.OrderBy(x => Guid.NewGuid());
                }



                var user = await _userManager.GetUserAsync(User);
                if (user != null)
                {
                    ViewBag.FavIds = _favouritesService.GetUserFavourites(user.Id).Select(f => f.Id).ToHashSet();
                }

                //Add Findex Score
                await _carService.AddFindexScore(cars, 0.25);
                ViewBag.Brands = await _brandService.GetAll();
                ViewBag.Request = req;
                ViewBag.Seats = carSeats;

                return View(await PaginatedList<Car>.CreateAsync(cars, page ?? 1, 4));
            }
        
    }
}

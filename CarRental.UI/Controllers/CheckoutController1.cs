using CarRental.Application.Contracts.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe.Checkout;

namespace CarRental.UI.Controllers
{
    [Route("[controller]")]
    public class CheckoutController : Controller
    {
        private readonly IRentalService _rentalService;
        private readonly IPaymentService _paymentService;

        public CheckoutController(IRentalService rentalService, IPaymentService paymentService)
        {
            _rentalService = rentalService;
            _paymentService = paymentService;
        }

        [HttpGet("Success")]
        public async Task<IActionResult> SuccessAsync(string sessionId)
        {
            if (string.IsNullOrEmpty(sessionId)) 
            {
                return LocalRedirect("/Home");
            }
            var sessionService = new SessionService();
            var session = await sessionService.GetAsync(sessionId);
            if (session == null) 
            {
                return LocalRedirect("/Home");
            }
            var payment = await _paymentService.AsQueryable().FirstOrDefaultAsync(x=>x.Session == session.Id);
            if (payment == null) 
            {
                return LocalRedirect("/Home");
            }
            payment.Status = Data.Abstracts.PaymentStatus.Paid;
            payment.StripePayment = session.PaymentIntentId;
            await _paymentService.Update(payment);
            // Here you can save order and customer details to your database.
            var total = session.AmountTotal.Value;
            var customerEmail = session.CustomerDetails.Email;
            return View(payment);
        }
        [HttpGet("Error")]
        public  IActionResult Error()
        {
            return View();
        }
    }
}

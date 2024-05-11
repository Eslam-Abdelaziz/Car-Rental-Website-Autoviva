using CarRental.Data.Abstracts;
using System.Reflection.Metadata;

namespace CarRental.Data.Models.Entities
{
	public class Payment
	{
		public int Id { get; set; }		
		public int RentalId { get; set; } // Required foreign key property
		public Rental Rental { get; set; }
		public PaymentStatus Status { get; set; }
		public PaymentType Type { get; set; }
		public string? Session { get; set; }
		public string? StripePayment { get; set; }

		public decimal TotalPrice { get; set; }
	}
}


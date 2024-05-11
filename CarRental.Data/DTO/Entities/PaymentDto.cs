using CarRental.Data.Abstracts;

namespace CarRental.Data.DTO.Entities
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public PaymentStatus Status { get; set; }
        public PaymentType Type { get; set; }
        public string Session { get; set; }
        public string StripePayment { get; set; }
        public decimal TotalPrice { get; set; }

    }
}

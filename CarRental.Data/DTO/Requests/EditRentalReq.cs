using CarRental.Data.Abstracts;

namespace CarRental.Data.DTO.Requests
{
    public class EditRentalReq
    {
        public int Id { get; set; }
        public RentalStatus RentalStatus { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
    }
}

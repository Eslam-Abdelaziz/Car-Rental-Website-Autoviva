using CarRental.Data.Abstracts;
using CarRental.Data.Models.Entities;

namespace CarRental.Data.DTO.Entities
{
    public class RentalDto
    {
        public int Id { get; set; }
        public CarDto Car { get; set; }
        public UserDto User { get; set; }
        public PaymentDto Payment { get; set; } // Reference navigation to dependent
        public RentalStatus Status { get; set; }

        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public BranchDto ReturnBranch { get; set; }
    }
}

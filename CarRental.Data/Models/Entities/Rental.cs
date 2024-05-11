using CarRental.Data.Abstracts;

namespace CarRental.Data.Models.Entities
{
    public class Rental 
    {
        public int Id { get; set; }



        public int CarId { get; set; }
        public Car Car { get; set; }


        public string UserId { get; set; }
        public User User { get; set; }

        public Payment Payment { get; set; } // Reference navigation to dependent
		public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public RentalStatus Status { get; set; }
		public int BranchId { get; set; }
		public Branch ReturnBranch { get; set; }

	}
}

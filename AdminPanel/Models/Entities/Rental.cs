using System;

namespace AdminPanel.Models.Entities
{
    public class Rental
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public User User { get; set; }
        public Payment Payment { get; set; } // Reference navigation to dependent
        public RentalStatus Status { get; set; }

        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Branch ReturnBranch { get; set; }
    }
}

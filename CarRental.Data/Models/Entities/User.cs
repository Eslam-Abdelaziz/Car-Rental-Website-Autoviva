using Microsoft.AspNetCore.Identity;

namespace CarRental.Data.Models.Entities
{
    public class User : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string? EmailConfirmationToken { get; set; }
        public string? ResetPasswordToken { get; set; }
        public DateTime ResetPasswordExpires { get; set; }
        public DateTime CreatedDate { get; set; }
        public  Address Address { get; set; }



		public int? BranchId { get; set; } // Required foreign key property
		public Branch? Branch { get; set; }

        public List<Rental> Rentals { get; set; }

        public List<Favourite> Favourites { get; set; }
		public override string ToString()
		{
            return string.Format("{0} {1}",Firstname,Lastname);
		}

	}
}

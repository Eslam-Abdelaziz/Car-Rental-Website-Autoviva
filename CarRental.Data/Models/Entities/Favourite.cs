using Microsoft.EntityFrameworkCore;

namespace CarRental.Data.Models.Entities
{
	public class Favourite
	{
		public int CarId { get; set; }
		public Car Car { get; set; }

		public string UserId { get; set; }
		public User User { get; set; }
	}
}

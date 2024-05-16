namespace CarRental.UI.Models.Cars
{
	public class CarSearchReq 
	{

		public string? Keyword { get; set; }
		public int? Sort { get; set; }
		public int? Brand { get; set; }
		public bool? Gasoline { get; set; }
		public bool? Eletric { get; set; }

		public bool? Manual { get; set; }
		public bool? Automatic { get; set; }
		public int? Seats { get; set; }
	}
}

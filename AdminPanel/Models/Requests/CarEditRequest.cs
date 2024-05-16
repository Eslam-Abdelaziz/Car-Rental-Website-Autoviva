namespace AdminPanel.Models.Requests
{
	public class CarEditRequest
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int BrandId { get; set; } // Required foreign key property
		public int ColorId { get; set; } // Required foreign key property
		public int BranchId { get; set; } // Required foreign key property
        public int ModelId { get; set; }// Required foreign key property

        public CarSize Size { get; set; }
		public decimal DailyPrice { get; set; }
		public int ModelYear { get; set; }
		public int Seats { get; set; }
		public bool IsElectric { get; set; }
        public bool IsAutomatic { get; set; }
        public double FuelUsage { get; set; }
    }

}

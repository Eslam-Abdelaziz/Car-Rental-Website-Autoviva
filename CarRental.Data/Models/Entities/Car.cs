using CarRental.Data.Abstracts;
using Microsoft.AspNetCore.Components.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Data.Models.Entities
{
    public class Car : BaseEntity
    {
		public int ColorId { get; set; } // Required foreign key property
		public Color Color { get; set; }

		public int BranchId { get; set; } // Required foreign key property
		public Branch Branch { get; set; }


		public int BrandId { get; set; } // Required foreign key property
		public Brand Brand { get; set; }

        public int ModelId { get; set; } // Required foreign key property
        public Model Model { get; set; }
        public IList<CarImage> CarImages { get; set; }
        public CarSize Size { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public double FindexScore { get; set; }
        public DateTime LastFindexScore { get; set; }
        public int Seats { get; set; }
        public bool IsElectric { get; set; }
        public bool IsAutomatic { get; set; }

        public double FuelUsage { get; set; }
        [NotMapped]
        public bool IsFavourite { set; get; }
    }
}

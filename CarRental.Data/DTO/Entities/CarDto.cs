using CarRental.Data.Abstracts;
using CarRental.Data.Models.Entities;

namespace CarRental.Data.DTO.Entities
{
    public class CarDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ColorDto Color { get; set; }
        public ICollection<CarImageDto> CarImages { get; set; }

        public BranchDto Branch { get; set; }
        public BrandDto Brand { get; set; }

        public ModelDto Model { get; set; }
        public bool IsAutomatic { get; set; }

        public double FuelUsage { get; set; }

        public CarSize Size { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public int Seats { get; set; }
        public bool IsElectric { get; set; }
    }
}

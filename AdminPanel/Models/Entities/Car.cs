using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
        public Branch Branch { get; set; }
        public Brand Brand { get; set; }
		public ICollection<CarImage> CarImages { get; set; }
		public CarSize Size { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public int Seats { get; set; }
        public bool IsElectric { get; set; }
        public bool IsAutomatic { get; set; }
        public double FuelUsage { get; set; }
        public Model Model { get; set; }

    }

}

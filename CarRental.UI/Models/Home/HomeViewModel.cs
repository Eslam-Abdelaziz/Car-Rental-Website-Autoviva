using CarRental.Data.Models.Entities;

namespace CarRental.UI.Models.Home
{
    public class HomeViewModel
    {
        public IEnumerable<int> Years { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<Branch> Branches { get; set; }
        public IEnumerable<Car> FeaturedCars { get; set; }
    }
}

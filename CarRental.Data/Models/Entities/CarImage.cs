namespace CarRental.Data.Models.Entities
{
    public class CarImage
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}

namespace CarRental.Data.Models.Entities
{
	public class Branch : BaseEntity
    {
		public Address Address { get; set; }
		public List<User> Users { get; set; }

		public ICollection<Car> Cars { get; } = new List<Car>(); // Collection navigation containing dependents
		public ICollection<Rental> Rentals { get; } = new List<Rental>(); // Collection navigation containing dependents


		public Branch()
		{
		}
        public Branch( string name)
        {
            Name = name;
        }
        public Branch(int id ,string name)
        {
            Name = name;
            Id = id;
        }
    }
}

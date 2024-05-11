namespace CarRental.Data.Models.Entities
{
    public class Brand : BaseEntity
	{
		public ICollection<Car> Cars { get; } = new List<Car>(); // Collection navigation containing dependents

		public ICollection<Model> Models { get; } = new List<Model>();

		public Brand()
        {

        }
        public Brand(int id , string name)
        {
            Id = id;
            Name = name;
        }
    }
}

namespace CarRental.Data.Models.Entities
{
    public class Color : BaseEntity
    {
		public ICollection<Car> Cars { get; } = new List<Car>(); // Collection navigation containing dependents

	}
}

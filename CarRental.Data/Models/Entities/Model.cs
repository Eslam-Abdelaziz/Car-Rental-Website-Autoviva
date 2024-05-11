using System.Text.Json.Serialization;

namespace CarRental.Data.Models.Entities
{
	public class Model : BaseEntity
	{
		public int BrandId { get; set; }

		[JsonIgnore]
		public Brand Brand { get; set; }
	}
}

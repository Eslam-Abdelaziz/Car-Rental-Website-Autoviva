using CarRental.Data.Models.Entities;

namespace CarRental.Application.Contracts.Entities
{
	public interface IRentalService : IGenericRepository<Rental>
	{
		Task<Rental?> GetRentalAsync(int id);
		Task<IList<Rental>> GetRentalsAsync(int count = 100);
		Task<IList<Rental>> GetRentalsByBranchAsync(int branchid, int count = 100);
	}
}

using CarRental.Application.Contracts.Entities;
using CarRental.Data;
using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Application.Repositories.Entities
{
	public class RentalService : GenericRepository<Rental>, IRentalService
	{
		private readonly ApplicationDbContext _dbContext;
		public RentalService(ApplicationDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Rental?> GetRentalAsync(int id)
		{
			return await _dbContext.Rentals
				.Include(x => x.Car)
				.Include(x => x.Car.Branch)
				.Include(x => x.Car.Color)
				.Include(x => x.User)
				.Include(x => x.Payment).Include(x => x.ReturnBranch)
				.FirstOrDefaultAsync(x=>x.Id == id);
		}

		public async Task<IList<Rental>> GetRentalsAsync(int count = 100)
		{
			return await _dbContext.Rentals
			   .Include(x => x.Car)
			   .Include(x => x.User)
			   .Include(x => x.Payment)
               .Include(x => x.ReturnBranch)
               .Include(x => x.Car.Branch)
               .Include(x => x.Car.Color)

               .Take(count).ToListAsync();
		}

		public async Task<IList<Rental>> GetRentalsByBranchAsync(int branchid,int count = 100)
		{
			return await _dbContext.Rentals
				.Include(x => x.Car)
               .Include(x => x.User)
               .Include(x => x.Payment)
               .Include(x => x.ReturnBranch)
               .Include(x => x.Car.Branch)
               .Include(x => x.Car.Color)
           .Where(x=>x.Car.BranchId == branchid).Take(count).ToListAsync();
		}
	}
}

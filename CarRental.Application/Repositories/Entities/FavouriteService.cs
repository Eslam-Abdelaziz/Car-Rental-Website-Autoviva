using CarRental.Application.Contracts.Entities;
using CarRental.Data;
using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Application.Repositories.Entities
{
	public class FavouriteService : GenericRepository<Favourite> ,IFavouritesService
	{
		private ApplicationDbContext _dbContext { get; set; }
		public FavouriteService(ApplicationDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<bool> AddRemoveFavourite(Favourite f)
		{
			try
			{
				
				var fav = await _dbContext.Favourites.FindAsync(f.CarId, f.UserId);
				if (fav == null)
				{
					await _dbContext.Favourites.AddAsync(f);
				}
				else
				{
					_dbContext.Favourites.Remove(fav);
				}
				await _dbContext.SaveChangesAsync();

				return fav == null;

			}
			catch (Exception ex)
			{

				return false;
			}
			
		
			
		}
		public IQueryable<Car> GetUserFavourites(string userId) 
		{
			return _dbContext.Favourites.Where(fav => fav.UserId == userId).Include(fav=>fav.Car)
				.Select(fav => fav.Car);
		}

    }
}

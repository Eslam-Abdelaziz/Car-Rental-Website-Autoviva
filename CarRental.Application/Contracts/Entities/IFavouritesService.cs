using CarRental.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Contracts.Entities
{
	public interface IFavouritesService : IGenericRepository<Favourite>
	{
		Task<bool> AddRemoveFavourite(Favourite favourite);
		IQueryable<Car> GetUserFavourites(string userId);

    }
}

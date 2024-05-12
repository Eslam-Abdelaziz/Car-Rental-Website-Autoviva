using CarRental.Application.Contracts.Entities;
using CarRental.Data;
using CarRental.Data.Models.Entities;

namespace CarRental.Application.Repositories.Entities
{
    public class ColorService : GenericRepository<Color>, IColorService
    {
        public ColorService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

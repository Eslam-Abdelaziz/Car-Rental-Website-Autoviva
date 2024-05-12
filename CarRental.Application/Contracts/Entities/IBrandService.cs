using CarRental.Data.Models.Entities;

namespace CarRental.Application.Contracts.Entities
{
    public interface IBrandService : IGenericRepository<Brand>
    {
        Task<bool> Exists(string name);
        Task<IList<Brand>> GetBrands();

	}
}

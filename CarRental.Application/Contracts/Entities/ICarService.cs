using CarRental.Data.Models.Entities;

namespace CarRental.Application.Contracts.Entities
{
    public interface ICarService : IGenericRepository<Car>
    {
        Task<IList<Car>> GetCars(string? name, int? modelyear, int? brandid, int? branchid, int? colorid, int? size, int? seats, double? price, bool? isElectric,bool? IsAutomatic);
        Task<int> TotalCars(int? branchid);
        Task<Car?> GetCar(int id);
        IQueryable<Car> GetAllCars();
        Task AddFindexScore(Car car, double actionScore);
        Task AddFindexScore(IQueryable<Car> car, double actionScore);

    }
}

using CarRental.Data.Models.Entities;

namespace CarRental.Application.Contracts.Entities
{
    public interface IUserService : IGenericRepository<User>
    {
        Task<List<User>> GetUsers(string? email, string? first, string? last, string? City, string? Phone);
    }
}

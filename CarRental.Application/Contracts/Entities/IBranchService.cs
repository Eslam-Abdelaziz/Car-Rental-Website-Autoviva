using CarRental.Data.Models.Entities;

namespace CarRental.Application.Contracts.Entities
{
    public interface IBranchService : IGenericRepository<Branch>
    {
        Task<IList<Branch>> GetBranches();
        Task<Branch> GetBranch(int id);
    }
}

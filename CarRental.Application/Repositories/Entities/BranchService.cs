using CarRental.Application.Contracts.Entities;
using CarRental.Data;
using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace CarRental.Application.Repositories.Entities
{
    public class BranchService : GenericRepository<Branch>, IBranchService
    {
        private readonly ApplicationDbContext applicationDb;
        public BranchService( ApplicationDbContext applicationDb) : base(applicationDb)
        {
            this.applicationDb = applicationDb;
        }

        public async Task<IList<Branch>> GetBranches()
        {
            return await applicationDb.Branches.Include(x => x.Address).ToListAsync();
        }
        public async Task<Branch?> GetBranch(int id)
        {
            return await applicationDb.Branches.Include(x => x.Address).Where(x=>x.Id == id).FirstOrDefaultAsync();
        }
    }
}

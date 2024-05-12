using CarRental.Application.Contracts.Entities;
using CarRental.Data;
using CarRental.Data.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Repositories.Entities
{
    public class BrandService : GenericRepository<Brand>, IBrandService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public BrandService(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public Task<bool> Exists(string name)
        {
           return applicationDbContext.Brands.AnyAsync(x => x.Name == name);
        }
		public async Task<IList<Brand>> GetBrands() 
        {
            return await applicationDbContext.Brands.Include(b=>b.Models)
                .ToListAsync();
        }

  
	}
}

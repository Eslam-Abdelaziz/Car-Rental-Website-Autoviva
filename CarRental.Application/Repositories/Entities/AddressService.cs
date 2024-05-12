using CarRental.Application.Contracts.Entities;
using CarRental.Data;
using CarRental.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Repositories.Entities
{
    public class AddressService : GenericRepository<Address>, IAddressService
    {
        public AddressService(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

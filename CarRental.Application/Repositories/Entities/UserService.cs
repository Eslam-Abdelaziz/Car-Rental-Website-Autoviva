using CarRental.Application.Contracts;
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
    public class UserService : GenericRepository<User>, IUserService
    {
        private readonly ApplicationDbContext _DbContext;
        public UserService(ApplicationDbContext dbContext) : base(dbContext)
        {
            _DbContext = dbContext;
        }

        public Task<List<User>> GetUsers(string? email, string? first, string? last, string? City, string? Phone)
        {

            var q = _DbContext.Users.Include(x => x.Address).AsQueryable() ;

            if (email != null)
            {
                q = q.Where(x => x.Email.Contains(email));
            }
            if (first != null)
            {
                q =  q.Where(x => x.Firstname.Contains(first));
            }
            if (last != null)
            {
                q = q.Where(x => x.Lastname.Contains(last));
            }
            if (City != null)
            {
                q = q.Where(x => x.Address.City.Contains(City));
            }
            if (Phone != null)
            {
                q = q.Where(x => x.Address.Phone.Contains(Phone));
            }
            return q.Include(x=>x.Address).Take(100)
              .ToListAsync();
        }

        //public Task<Queryable<Favourite>> GetUserFavorite 
    }
}

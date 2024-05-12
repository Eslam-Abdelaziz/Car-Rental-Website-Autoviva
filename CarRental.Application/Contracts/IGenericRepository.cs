using CarRental.Data.Abstracts;
using CarRental.Data.Return;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Application.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> Get(int id);
        Task<IList<T>> GetAll();
        IQueryable<T> AsQueryable();
        Task<T> Add(T entity);
        Task<bool> Exists(int id);
        Task Update(T entity);
        Task Delete(T entity);
    }

}

using CarRental.Application.Contracts;
using CarRental.Data;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Application.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<T> Add(T entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        public IQueryable<T> AsQueryable()
        {
            return _dbContext.Set<T>().AsQueryable();
        }
        public async Task Delete(T entity)
        {
           await Task.Run(async () => 
           {
               _dbContext.Set<T>().Remove(entity);
               await _dbContext.SaveChangesAsync();
           }); 
        }
        public async Task<bool> Exists(int id)
        {
            var entity = await Get(id);
            return entity != null;
        }
        public async Task<T?> Get(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }
        public async Task<IList<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }
        public async Task Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

    }

}

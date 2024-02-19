using DemoCQRSMedi.Application.Contrats;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DemoCQRSMedi.Persistence.Repositories
{
    public class GenericRepository<T> : IAsyncRepos<T> where T : class
    {
        protected readonly LibraryDbContext _dbContext;
        private readonly DbSet<T> _entitiySet;

        public GenericRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
            _entitiySet = _dbContext.Set<T>();
        }

        public virtual async Task<T> GetByIdAsync(Guid Id)
            => await _entitiySet.FindAsync(Id);
        public async Task<IReadOnlyList<T>> GetAllAsync()
            => await _entitiySet.ToListAsync();

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpDateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}

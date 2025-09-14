using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Repositories
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected readonly DbSet<T> dbSet;
        protected readonly CoreDbContext coreDbContext;

        public BaseRepository(CoreDbContext dbContext)
        {
            this.coreDbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            this.dbSet = this.coreDbContext.Set<T>();
        }


        public async Task CreateAsync(T entity)
        {
            await dbSet.FindAsync(entity);
        }

        public async Task CreateAsync(IEnumerable<T> entities)
        {
            await dbSet.AddRangeAsync(entities);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Delete(IEnumerable<T> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }

        public void Update(IEnumerable<T> entities)
        {
            dbSet.UpdateRange(entities);
        }
    }
}

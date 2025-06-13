using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.Repositories
{
    public abstract class BaseRepository<T>
        where T : class
    {
        protected readonly DbContext _dbContext;
        protected readonly DbSet<T> _dbSet = null!;

        protected BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
    }
}

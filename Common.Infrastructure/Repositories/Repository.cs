using Common.Core.Data.Contracts.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Common.Infrastructure.Repositories
{
    public abstract class Repository<T> : BaseRepository<T>, IRepository<T>
        where T : class
    {
        protected Repository(DbContext dbContext) : base(dbContext)
        {
        }

        protected Repository(DbSet<T> dbSet) : base(dbSet)
        {
        }
    }
}

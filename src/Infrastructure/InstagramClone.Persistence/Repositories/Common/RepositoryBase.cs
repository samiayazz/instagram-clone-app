using System.Linq.Expressions;
using InstagramClone.Application.Interfaces.Repository.Common;
using InstagramClone.Domain.Interfaces.Base;
using InstagramClone.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Persistence.Repositories.Common
{
    public abstract class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity
        where TKey : struct
    {
        protected AppDbContext DbContext { get; init; }
        protected DbSet<TEntity> Table { get; init; }

        protected RepositoryBase(AppDbContext dbContext)
            => (DbContext, Table) = (dbContext, dbContext.Set<TEntity>());

        public async Task<ICollection<TEntity>?> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null)
        {
            IQueryable<TEntity> query = Table;
            if (predicate != null)
                query = query.Where(predicate);

            return await query.ToListAsync();
        }

        public async Task<TEntity?> GetSingleAsync(Expression<Func<TEntity, bool>> predicate)
            => await Table.SingleOrDefaultAsync(predicate);

        public async Task<TEntity?> GetByIdAsync(TKey id)
            => await Table.FindAsync(id);

        public async Task<long> CountAsync()
            => await Table.CountAsync();

        public async Task<bool> CreateAsync(TEntity entity)
        {
            Table.Add(entity);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> CreateRangeAsync(ICollection<TEntity> entities)
        {
            Table.AddRange(entities);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            Table.Update(entity);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateRangeAsync(ICollection<TEntity> entities)
        {
            Table.UpdateRange(entities);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveAsync(TEntity entity)
        {
            Table.Remove(entity);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRangeAsync(ICollection<TEntity> entities)
        {
            Table.RemoveRange(entities);
            return await DbContext.SaveChangesAsync() > 0;
        }
    }
}
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Domain.Interfaces.Base;
using InstagramClone.Persistence.Contexts;

namespace InstagramClone.Persistence.Repositories.Common
{
    public abstract class SoftRemovableRepositoryBase<TEntity, TKey> : RepositoryBase<TEntity, TKey>
        where TEntity : class, IModifiableEntity
        where TKey : struct
    {
        protected SoftRemovableRepositoryBase(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> SoftRemoveAsync(TEntity entity)
        {
            entity.IsRemoved = true;
            Table.Update(entity);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> SoftRemoveRangeAsync(ICollection<TEntity> entities)
        {
            entities.ToList().ForEach(x => x.IsRemoved = true);
            Table.UpdateRange(entities);
            return await DbContext.SaveChangesAsync() > 0;
        }
    }
}
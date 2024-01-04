using InstagramClone.Domain.Interfaces.Base;

namespace InstagramClone.Application.Interfaces.Repository.Common
{
    public interface ISoftRemovableRepository<TEntity, in TKey> : IRepository<TEntity, TKey>
        where TEntity : class, IModifiableEntity
        where TKey : struct
    {
        Task<bool> SoftRemoveAsync(TEntity entity);

        Task<bool> SoftRemoveRangeAsync(ICollection<TEntity> entities);
    }
}
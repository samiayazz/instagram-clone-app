using System.Linq.Expressions;
using InstagramClone.Domain.Interfaces.Base;

namespace InstagramClone.Application.Interfaces.Repository.Common
{
    public interface IRepository<TEntity, in TKey>
        where TEntity : class, IEntity
        where TKey : struct
    {
        Task<ICollection<TEntity>?> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null);

        Task<TEntity?> GetSingleAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity?> GetByIdAsync(TKey id);

        Task<long> CountAsync();

        Task<bool> CreateAsync(TEntity entity);

        Task<bool> CreateRangeAsync(ICollection<TEntity> entities);

        Task<bool> UpdateAsync(TEntity entity);

        Task<bool> UpdateRangeAsync(ICollection<TEntity> entities);

        Task<bool> RemoveAsync(TEntity entity);

        Task<bool> RemoveRangeAsync(ICollection<TEntity> entities);
    }
}
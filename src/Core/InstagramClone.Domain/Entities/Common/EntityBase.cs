using InstagramClone.Domain.Interfaces;

namespace InstagramClone.Domain.Entities.Common
{
    public abstract class EntityBase : IEntity
    {
        protected EntityBase(Guid id)
            => Id = id;

        public Guid Id { get; init; }
    }
}
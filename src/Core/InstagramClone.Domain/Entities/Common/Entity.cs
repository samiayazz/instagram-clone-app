using InstagramClone.Domain.Interfaces;

namespace InstagramClone.Domain.Entities.Common
{
    public abstract class Entity : IEntity
    {
        protected Entity(Guid id)
            => Id = id;

        public Guid Id { get; init; }
    }
}
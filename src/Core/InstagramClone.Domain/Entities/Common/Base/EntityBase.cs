using InstagramClone.Domain.Interfaces.Base;

namespace InstagramClone.Domain.Entities.Common.Base
{
    public abstract class EntityBase : IEntity
    {
        protected EntityBase()
        {
        }

        protected EntityBase(Guid id)
            => Id = id;

        public Guid Id { get; private init; } = Guid.NewGuid();
    }
}
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Entities.Common.Base
{
    public abstract class ModifiableEntityBase : EntityBase
    {
        protected ModifiableEntityBase()
        {
        }

        protected ModifiableEntityBase(Guid id) : base(id)
        {
        }

        public Guid CreatedById { get; private set; } = default!;
        public virtual AppUser CreatedBy { get; private set; } = default!;
        public DateTime CreatedDate { get; private set; } = default!;

        public Guid? UpdatedById { get; private set; } = default!;
        public virtual AppUser? UpdatedBy { get; private set; } = default!;
        public DateTime? UpdatedDate { get; private set; } = default!;

        public Guid? RemovedById { get; private set; } = default!;
        public virtual AppUser? RemovedBy { get; private set; } = default!;
        public DateTime? RemovedDate { get; private set; } = default!;
        public bool IsRemoved { get; set; } = false;
    }
}
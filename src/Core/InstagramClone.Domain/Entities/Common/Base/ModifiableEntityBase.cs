using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Entities.Common.Base
{
    public abstract class ModifiableEntityBase : EntityBase
    {
        protected ModifiableEntityBase(Guid id, Guid createdById) : base(id)
            => CreatedById = createdById;

        public Guid CreatedById { get; private init; }
        public virtual AppUser CreatedBy { get; private set; } = default!;
        public DateTime CreatedDate { get; private init; } = DateTime.UtcNow;

        public Guid? UpdatedById { get; set; } = default!;
        public virtual AppUser? UpdatedBy { get; set; } = default!;
        public DateTime? UpdatedDate { get; set; } = default!;

        public Guid? RemovedById { get; set; } = default!;
        public virtual AppUser? RemovedBy { get; set; } = default!;
        public DateTime? RemovedDate { get; set; } = default!;
    }
}
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Entities.Common
{
    public abstract class ModifiableEntity : Entity
    {
        protected ModifiableEntity(Guid id, Guid createdById) : base(id)
            => CreatedById = createdById;

        public Guid CreatedById { get; init; }
        public virtual AppUser CreatedBy { get; init; } = default!;
        public DateTime CreatedDate { get; init; } = DateTime.UtcNow;

        public Guid? UpdatedById { get; set; }
        public virtual AppUser? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public Guid? RemovedById { get; set; }
        public virtual AppUser? RemovedBy { get; set; }
        public DateTime? RemovedDate { get; set; }
    }
}
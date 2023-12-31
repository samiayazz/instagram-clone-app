using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Interfaces
{
    public interface IModifiableEntity : IEntity
    {
        public Guid CreatedById { get; init; }
        public AppUser CreatedBy { get; init; }
        public DateTime CreatedDate { get; init; }

        public Guid? UpdatedById { get; set; }
        public AppUser? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public Guid? RemovedById { get; set; }
        public AppUser? RemovedBy { get; set; }
        public DateTime? RemovedDate { get; set; }
    }
}
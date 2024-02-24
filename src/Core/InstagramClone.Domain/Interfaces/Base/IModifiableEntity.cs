using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Interfaces.Base
{
    public interface IModifiableEntity : IEntity
    {
        Guid CreatedById { get; }
        AppUser CreatedBy { get; }
        DateTime CreatedDate { get; }

        Guid? UpdatedById { get; }
        AppUser? UpdatedBy { get; }
        DateTime? UpdatedDate { get; }

        Guid? RemovedById { get; }
        AppUser? RemovedBy { get; }
        DateTime? RemovedDate { get; }
        bool IsRemoved { get; set; }
    }
}
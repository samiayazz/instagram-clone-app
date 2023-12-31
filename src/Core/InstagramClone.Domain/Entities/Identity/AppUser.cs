using InstagramClone.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace InstagramClone.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>, IEntity
    {
        public AppUser(Guid id, Guid roleId, string userName, string email, string passwordHash)
        {
            Id = id;
            RoleId = roleId;
            UserName = userName;
            Email = email;
            PasswordHash = passwordHash;
        }

        public new Guid Id { get; init; }

        public new string UserName { get; set; }
        public new string Email { get; set; }
        public new string PasswordHash { get; set; }

        public Guid RoleId { get; set; }
        public virtual AppRole Role { get; set; } = default!;

        public DateTime CreatedDate { get; init; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? RemovedDate { get; set; }
    }
}
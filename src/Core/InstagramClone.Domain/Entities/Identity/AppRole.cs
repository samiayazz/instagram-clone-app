using InstagramClone.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace InstagramClone.Domain.Entities.Identity
{
    public class AppRole : IdentityRole<Guid>, IEntity
    {
        public AppRole(Guid id, string name)
            => (Id, Name) = (id, name);

        public new Guid Id { get; init; }
        public new string Name { get; init; }


        public virtual IEnumerable<AppUser> Users { get; protected set; } = default!;
    }
}
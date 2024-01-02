using InstagramClone.Domain.Entities.Chat;
using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Entities
{
    public class Group : ModifiableEntityBase
    {
        public Group(Guid id, Guid createdById, string name, string about) : base(id, createdById)
            => (Name, About) = (name, about);

        public string Name { get; set; }
        public string About { get; set; }
        public virtual IEnumerable<AppUser> Participants { get; private set; } = default!;
        public virtual IEnumerable<Message> Messages { get; private set; } = default!;
    }
}
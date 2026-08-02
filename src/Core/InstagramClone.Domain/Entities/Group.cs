using InstagramClone.Domain.Entities.Chat;
using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Entities
{
    public class Group : ModifiableEntityBase
    {
        public Group(string name, string about)
            => (Name, About) = (name, about);

        public Group(Guid id, string name, string about) : base(id)
            => (Name, About) = (name, about);

        public string Name { get; set; }
        public string About { get; set; }
        public virtual IEnumerable<AppUser> Participants { get; private set; } = default!;
        public virtual IEnumerable<Message> Messages { get; private set; } = default!;
    }
}
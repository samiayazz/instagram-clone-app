using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Entities.Content
{
    public class Comment : ModifiableEntityBase
    {
        public Comment(Guid id, Guid createdById, Guid postId, string text, bool isReply = false)
            : base(id, createdById)
            => (PostId, Text, IsReply) = (postId, text, isReply);

        public bool IsReply { get; private init; }

        public string Text { get; set; }

        public Guid PostId { get; private init; }
        public virtual Post Post { get; private set; } = default!;

        public virtual IEnumerable<AppUser> LikedUsers { get; private set; } = default!;
    }
}
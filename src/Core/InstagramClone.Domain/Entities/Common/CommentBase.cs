using System.Collections;
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Common
{
    public class CommentBase<T> : ModifiableEntityBase where T : class
    {
        protected CommentBase(Guid id, Guid createdById, Guid postId, string text) : base(id, createdById)
            => (PostId, Text) = (postId, text);

        public string Text { get; set; }

        public Guid PostId { get; set; }

        public Guid? ParentId { get; protected set; }
        public virtual T? Parent { get; protected set; }
        public virtual IEnumerable<T>? Replies { get; set; }

        public virtual IEnumerable<AppUser> LikedUsers { get; protected set; }
    }
}
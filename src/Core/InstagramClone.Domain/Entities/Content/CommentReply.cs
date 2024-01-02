using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Entities.Content
{
    public class CommentReply : EntityBase
    {
        public CommentReply(Guid id, Guid repliedCommentId, Guid recipientId, Guid commentId) : base(id)
            => (RepliedCommentId, RecipientId, CommentId) = (repliedCommentId, recipientId, commentId);

        public Guid RepliedCommentId { get; private init; }
        public virtual Comment RepliedComment { get; private set; } = default!;

        public Guid RecipientId { get; private init; }
        public virtual AppUser Recipient { get; private set; } = default!;

        public Guid CommentId { get; private init; }
        public virtual Comment Comment { get; private set; } = default!;
    }
}
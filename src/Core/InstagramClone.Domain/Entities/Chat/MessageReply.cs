using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Entities.Chat
{
    public class MessageReply : EntityBase
    {
        public MessageReply(Guid id, Guid repliedMessageId, Guid recipientId, Guid messageId) : base(id)
            => (RepliedMessageId, RecipientId, MessageId) = (repliedMessageId, recipientId, messageId);

        public Guid RepliedMessageId { get; private init; }
        public virtual Message RepliedMessage { get; private set; } = default!;

        public Guid RecipientId { get; private init; }
        public virtual AppUser Recipient { get; private set; } = default!;

        public Guid MessageId { get; private init; }
        public virtual Message Message { get; private set; } = default!;
    }
}
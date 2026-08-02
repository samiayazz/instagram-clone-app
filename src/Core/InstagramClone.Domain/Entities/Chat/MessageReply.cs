using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Domain.Entities.Chat
{
    public class MessageReply : EntityBase
    {
        public MessageReply(Guid repliedMessageId, Guid messageId)
            => (RepliedMessageId, MessageId) = (repliedMessageId, messageId);

        public MessageReply(Guid id, Guid repliedMessageId, Guid messageId) : base(id)
            => (RepliedMessageId, MessageId) = (repliedMessageId, messageId);

        public Guid RepliedMessageId { get; private init; }
        public virtual Message RepliedMessage { get; private set; } = default!;

        public Guid MessageId { get; private init; }
        public virtual Message Message { get; private set; } = default!;
    }
}
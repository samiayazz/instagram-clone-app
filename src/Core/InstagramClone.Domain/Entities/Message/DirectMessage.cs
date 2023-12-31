using InstagramClone.Domain.Entities.Common;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Message
{
    public class DirectMessage : MessageBase<DirectMessage>
    {
        protected DirectMessage(Guid id, Guid createdById, MessageType type) : base(id, createdById, type)
        {
        }
    }
}
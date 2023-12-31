using InstagramClone.Domain.Entities.Common;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Message
{
    public class GroupMessage : MessageBase<GroupMessage>
    {
        protected GroupMessage(Guid id, Guid createdById, MessageType type) : base(id, createdById, type)
        {
        }
    }
}
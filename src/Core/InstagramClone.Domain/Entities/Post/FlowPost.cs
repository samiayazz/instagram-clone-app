using InstagramClone.Domain.Entities.Comment;
using InstagramClone.Domain.Entities.Common;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Post
{
    public class FlowPost : PostBase<FlowPostComment>
    {
        protected FlowPost(Guid id, Guid createdById, PostType type, string description) : base(id, createdById, type,
            description)
        {
        }
    }
}
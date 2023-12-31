using InstagramClone.Domain.Entities.Common;

namespace InstagramClone.Domain.Entities.Comment
{
    public class FlowPostComment : CommentBase<FlowPostComment>
    {
        protected FlowPostComment(Guid id, Guid createdById, Guid postId, string text) : base(id, createdById, postId,
            text)
        {
        }
    }
}
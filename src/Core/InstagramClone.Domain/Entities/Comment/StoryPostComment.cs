using InstagramClone.Domain.Entities.Common;

namespace InstagramClone.Domain.Entities.Comment
{
    public class StoryPostComment : CommentBase<StoryPostComment>
    {
        protected StoryPostComment(Guid id, Guid createdById, Guid postId, string text) : base(id, createdById, postId,
            text)
        {
        }
    }
}
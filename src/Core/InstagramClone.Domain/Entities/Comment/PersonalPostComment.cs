using InstagramClone.Domain.Entities.Common;

namespace InstagramClone.Domain.Entities.Comment
{
    public class PersonalPostComment : CommentBase<PersonalPostComment>
    {
        protected PersonalPostComment(Guid id, Guid createdById, Guid postId, string text) : base(id, createdById,
            postId, text)
        {
        }
    }
}
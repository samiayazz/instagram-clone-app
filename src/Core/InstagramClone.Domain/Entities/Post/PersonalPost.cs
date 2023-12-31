using InstagramClone.Domain.Entities.Comment;
using InstagramClone.Domain.Entities.Common;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Post
{
    public class PersonalPost : PostBase<PersonalPostComment>
    {
        protected PersonalPost(Guid id, Guid createdById, PostType type, string description) : base(id, createdById,
            type, description)
        {
        }
    }
}
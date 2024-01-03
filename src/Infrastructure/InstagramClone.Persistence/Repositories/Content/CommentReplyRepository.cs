using InstagramClone.Domain.Entities.Content;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories.Content
{
    public class CommentReplyRepository : RepositoryBase<CommentReply, Guid>
    {
        public CommentReplyRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
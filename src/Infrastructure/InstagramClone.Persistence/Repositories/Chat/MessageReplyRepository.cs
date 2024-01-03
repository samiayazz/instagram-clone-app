using InstagramClone.Domain.Entities.Chat;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories.Chat
{
    public class MessageReplyRepository : RepositoryBase<MessageReply, Guid>
    {
        public MessageReplyRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
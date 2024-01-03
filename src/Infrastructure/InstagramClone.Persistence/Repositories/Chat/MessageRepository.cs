using InstagramClone.Domain.Entities.Chat;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories.Chat
{
    public class MessageRepository : SoftRemovableRepositoryBase<Message, Guid>
    {
        public MessageRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
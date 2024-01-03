using InstagramClone.Application.Contracts.Repository.Chat;
using InstagramClone.Domain.Entities.Chat;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories.Chat
{
    public class MessageRepository : SoftRemovableRepositoryBase<Message, Guid>, IMessageRepository
    {
        public MessageRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
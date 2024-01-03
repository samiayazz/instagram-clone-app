using InstagramClone.Application.Contracts.Repository.Content;
using InstagramClone.Domain.Entities.Content;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories.Content
{
    public class PostRepository : SoftRemovableRepositoryBase<Post, Guid>, IPostRepository
    {
        public PostRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
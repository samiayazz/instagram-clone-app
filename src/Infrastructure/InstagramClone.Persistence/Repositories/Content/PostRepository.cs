using InstagramClone.Domain.Entities.Content;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories.Content
{
    public class PostRepository : SoftRemovableRepositoryBase<Post, Guid>
    {
        public PostRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
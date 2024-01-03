using InstagramClone.Domain.Entities;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories
{
    public class ThoughtRepository : SoftRemovableRepositoryBase<Thought, Guid>
    {
        public ThoughtRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
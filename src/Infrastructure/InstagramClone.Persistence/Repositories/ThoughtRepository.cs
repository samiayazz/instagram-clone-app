using InstagramClone.Application.Contracts.Repository;
using InstagramClone.Domain.Entities;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories
{
    public class ThoughtRepository : SoftRemovableRepositoryBase<Thought, Guid>, IThoughtRepository
    {
        public ThoughtRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
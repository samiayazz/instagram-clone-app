using InstagramClone.Application.Contracts.Repository;
using InstagramClone.Domain.Entities;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;

namespace InstagramClone.Persistence.Repositories
{
    public class GroupRepository : SoftRemovableRepositoryBase<Group, Guid>, IGroupRepository
    {
        public GroupRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
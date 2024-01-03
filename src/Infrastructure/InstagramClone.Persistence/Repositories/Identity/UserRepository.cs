using InstagramClone.Application.Contracts.Repository.Identity;
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Persistence.Repositories.Identity
{
    public class UserRepository : RepositoryBase<AppUser, Guid>, IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> IsEmailUniqueAsync(string email)
            => await Table.SingleOrDefaultAsync(x => x.Email == email) != null;
    }
}
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Persistence.Contexts;
using InstagramClone.Persistence.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Persistence.Repositories.Identity
{
    public class UserRepository : RepositoryBase<AppUser, Guid>
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CreateAsync(AppUser user)
        {
            if (!await this.IsEmailUniqueAsync(user.Email!))
                // Todo: Throw EmailIsNotUniqueException in here
                return false;

            Table.Add(user);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> CreateRangeAsync(ICollection<AppUser> users)
        {
            Table.AddRange(users);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(AppUser user)
        {
            Table.Update(user);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateRangeAsync(ICollection<AppUser> users)
        {
            Table.UpdateRange(users);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveAsync(AppUser user)
        {
            user.IsRemoved = true;
            Table.Update(user);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveRangeAsync(ICollection<AppUser> users)
        {
            users.ToList().ForEach(x => x.IsRemoved = true);
            Table.UpdateRange(users);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> IsEmailUniqueAsync(string email)
            => await Table.SingleOrDefaultAsync(x => x.Email == email) != null;
    }
}
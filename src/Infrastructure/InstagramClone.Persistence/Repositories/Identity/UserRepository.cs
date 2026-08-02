using InstagramClone.Application.Interfaces.Repository.Identity;
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

        public async Task<AppUser?> GetByUserNameOrEmailAndPasswordAsync(string userNameOrEmail, string password)
            => await this.GetSingleAsync(x
                => (x.UserName == userNameOrEmail || x.Email == userNameOrEmail)
                   && x.PasswordHash == password);

        public async Task<bool> IsEmailUniqueAsync(string email)
            => await Table.SingleOrDefaultAsync(x => x.Email == email) != null;

        public async Task<bool> SoftRemoveAsync(AppUser user)
        {
            user.IsRemoved = true;
            Table.Update(user);
            return await DbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> SoftRemoveRangeAsync(ICollection<AppUser> users)
        {
            users.ToList().ForEach(x => x.IsRemoved = true);
            Table.UpdateRange(users);
            return await DbContext.SaveChangesAsync() > 0;
        }
    }
}
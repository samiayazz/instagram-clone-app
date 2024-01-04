using InstagramClone.Application.Interfaces.Repository.Common;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Application.Interfaces.Repository.Identity
{
    public interface IUserRepository : IRepository<AppUser, Guid>
    {
        Task<AppUser?> GetByUserNameOrEmailAndPasswordAsync(string userNameOrEmail, string password);

        Task<bool> IsEmailUniqueAsync(string email);
    }
}
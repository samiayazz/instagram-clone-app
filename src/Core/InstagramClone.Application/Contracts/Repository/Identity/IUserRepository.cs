using InstagramClone.Application.Contracts.Repository.Common;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Application.Contracts.Repository.Identity
{
    public interface IUserRepository : IRepository<AppUser, Guid>
    {
        Task<bool> IsEmailUniqueAsync(string email);
    }
}
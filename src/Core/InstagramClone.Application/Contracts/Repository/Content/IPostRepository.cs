using InstagramClone.Application.Contracts.Repository.Common;
using InstagramClone.Domain.Entities.Content;

namespace InstagramClone.Application.Contracts.Repository.Content
{
    public interface IPostRepository : ISoftRemovableRepository<Post, Guid>;
}
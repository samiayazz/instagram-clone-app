using InstagramClone.Application.Interfaces.Repository.Common;
using InstagramClone.Domain.Entities.Content;

namespace InstagramClone.Application.Interfaces.Repository.Content
{
    public interface ICommentRepository : ISoftRemovableRepository<Comment, Guid>;
}
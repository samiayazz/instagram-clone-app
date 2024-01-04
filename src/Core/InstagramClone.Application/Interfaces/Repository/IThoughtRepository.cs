using InstagramClone.Application.Interfaces.Repository.Common;
using InstagramClone.Domain.Entities;

namespace InstagramClone.Application.Interfaces.Repository
{
    public interface IThoughtRepository : ISoftRemovableRepository<Thought, Guid>;
}
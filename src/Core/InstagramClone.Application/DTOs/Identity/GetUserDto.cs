using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Application.DTOs.Identity
{
    public class GetUserDto
    {
        public GetUserDto(long count, ICollection<AppUser>? users)
            => (Count, Users) = (count, users);

        public long Count { get; init; }
        public ICollection<AppUser>? Users { get; init; }
    }
}
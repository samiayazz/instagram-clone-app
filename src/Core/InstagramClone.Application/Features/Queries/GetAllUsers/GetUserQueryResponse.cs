using InstagramClone.Application.DTOs.Identity;

namespace InstagramClone.Application.Features.Queries.GetAllUsers
{
    public class GetUserQueryResponse
    {
        public GetUserQueryResponse(long count, ICollection<GetUserDto>? users)
            => (Count, Users) = (count, users);

        public long Count { get; init; }
        public ICollection<GetUserDto>? Users { get; init; }
    }
}
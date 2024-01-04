using InstagramClone.Application.DTOs.Identity;
using InstagramClone.Application.Responses;

namespace InstagramClone.Application.Features.Identity.Queries.GetUser
{
    public class GetUserQueryResponse : OkResponse<UserDto>
    {
        public GetUserQueryResponse(UserDto data, string message = "Operation successfull")
            : base(data, message)
        {
        }
    }
}
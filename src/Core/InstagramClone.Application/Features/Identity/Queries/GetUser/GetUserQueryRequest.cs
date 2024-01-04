using InstagramClone.Application.DTOs.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Queries.GetUser
{
    public class GetUserQueryRequest : IRequest<GetUserQueryResponse>
    {
        public GetUserQueryRequest(GetUserDto dto)
            => (Dto) = (dto);

        public GetUserDto Dto { get; init; }
    }
}
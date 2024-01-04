using InstagramClone.Application.DTOs.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Commands.CreateUser
{
    public class CreateUserCommandRequest : IRequest<CreateUserCommandResponse>
    {
        public CreateUserCommandRequest(CreateUserDto dto)
            => (Dto) = (dto);

        public CreateUserDto Dto { get; init; }
    }
}
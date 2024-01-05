using AutoMapper;
using InstagramClone.Application.DTOs.Identity;
using InstagramClone.Application.Interfaces.Repository.Identity;
using InstagramClone.Domain.Entities.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Commands
{
    public class CreateUserCommand : IRequest<bool>
    {
        public CreateUserCommand(CreateUserDto dto)
            => (Dto) = (dto);

        public CreateUserDto Dto { get; init; }

        public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
        {
            private readonly IUserRepository _repository;
            private readonly IMapper _mapper;

            public CreateUserCommandHandler(IUserRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<bool> Handle(CreateUserCommand command,
                CancellationToken cancellationToken)
                => await _repository.CreateAsync(_mapper.Map<AppUser>(command.Dto));
        }
    }
}
using AutoMapper;
using InstagramClone.Application.Interfaces.Repository.Identity;
using InstagramClone.Domain.Entities.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IUserRepository repository, IMapper mapper)
            => (_repository, _mapper) = (repository, mapper);

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request,
            CancellationToken cancellationToken)
            => await _repository.CreateAsync(_mapper.Map<AppUser>(request.Dto))
                ? new CreateUserCommandResponse()
                : throw new Exception();
    }
}
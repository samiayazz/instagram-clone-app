using AutoMapper;
using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.DTOs.Identity.Requests;
using InstagramClone.Application.Interfaces.Repository.Identity;
using InstagramClone.Domain.Entities.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Commands
{
    public class CreateUserCommand : IRequest<OkApiResponse>
    {
        public CreateUserCommand(WriteUserDto dto)
            => (Dto) = (dto);

        public WriteUserDto Dto { get; set; }


        public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, OkApiResponse>
        {
            private readonly IUserRepository _repository;
            private readonly IMapper _mapper;

            public CreateUserCommandHandler(IUserRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<OkApiResponse> Handle(CreateUserCommand request,
                CancellationToken cancellationToken)
            {
                if (!await _repository.IsEmailUniqueAsync(request.Dto.Email))
                    throw new Exception();

                bool isSuccess = await _repository.CreateAsync(_mapper.Map<AppUser>(request.Dto));
                if (!isSuccess)
                    throw new Exception();

                return new OkApiResponse();
            }
        }
    }
}
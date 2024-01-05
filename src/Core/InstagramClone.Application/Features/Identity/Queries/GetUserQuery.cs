using AutoMapper;
using InstagramClone.Application.DTOs.Identity;
using InstagramClone.Application.Interfaces.Repository.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Queries
{
    public class GetUserQuery : IRequest<UserDto>
    {
        public GetUserQuery(GetUserDto dto)
            => (Dto) = (dto);

        public GetUserDto Dto { get; init; }

        public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserDto>
        {
            private readonly IUserRepository _repository;
            private readonly IMapper _mapper;

            public GetUserQueryHandler(IUserRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<UserDto> Handle(GetUserQuery request,
                CancellationToken cancellationToken)
                => _mapper.Map<UserDto>(await _repository.GetByUserNameOrEmailAndPasswordAsync(
                    request.Dto.UserNameOrEmail, request.Dto.Password
                ));
        }
    }
}
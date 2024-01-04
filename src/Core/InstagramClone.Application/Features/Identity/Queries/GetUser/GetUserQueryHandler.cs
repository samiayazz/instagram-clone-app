using AutoMapper;
using InstagramClone.Application.DTOs.Identity;
using InstagramClone.Application.Interfaces.Repository.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQueryRequest, GetUserQueryResponse>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public GetUserQueryHandler(IUserRepository repository, IMapper mapper)
            => (_repository, _mapper) = (repository, mapper);

        public async Task<GetUserQueryResponse> Handle(GetUserQueryRequest request,
            CancellationToken cancellationToken)
            => new GetUserQueryResponse(_mapper.Map<UserDto>(
                await _repository.GetByUserNameOrEmailAndPasswordAsync(
                    request.Dto.UserNameOrEmail, request.Dto.Password
                )
            ));
    }
}
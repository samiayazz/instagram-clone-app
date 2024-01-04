using AutoMapper;
using InstagramClone.Application.Contracts.Repository.Identity;
using InstagramClone.Application.DTOs.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Queries.GetAllUsers
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQueryRequest, GetUserQueryResponse>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public GetUserQueryHandler(IUserRepository repository, IMapper mapper)
            => (_repository, _mapper) = (repository, mapper);

        public async Task<GetUserQueryResponse> Handle(GetUserQueryRequest request,
            CancellationToken cancellationToken)
        {
            var users = await _repository.GetAllAsync();
            long count = 0;
            if (users?.Count > 0)
                count = users.Count;

            return new GetUserQueryResponse(
                count,
                _mapper.Map<ICollection<GetUserDto>>(users)
            );
        }
    }
}
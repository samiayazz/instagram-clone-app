using AutoMapper;
using InstagramClone.Application.ApiResponses;
using InstagramClone.Application.DTOs.Identity.Views;
using InstagramClone.Application.Interfaces.Repository.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Queries
{
    public class GetUserByIdQuery : IRequest<DataApiResponse<ViewUserDto>>
    {
        public GetUserByIdQuery(Guid id)
            => (Id) = (id);

        private Guid Id { get; set; }


        public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, DataApiResponse<ViewUserDto>>
        {
            private readonly IUserRepository _repository;
            private readonly IMapper _mapper;

            public GetUserByIdQueryHandler(IUserRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<DataApiResponse<ViewUserDto>> Handle(GetUserByIdQuery request,
                CancellationToken cancellationToken)
            {
                var dto = _mapper.Map<ViewUserDto>(await _repository.GetByIdAsync(request.Id));
                return new DataApiResponse<ViewUserDto>(dto);
            }
        }
    }
}
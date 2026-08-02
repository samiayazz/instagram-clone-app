using AutoMapper;
using InstagramClone.Application.ApiResponses;
using InstagramClone.Application.DTOs.Group.Views;
using InstagramClone.Application.Interfaces.Repository;
using MediatR;

namespace InstagramClone.Application.Features.Group.Queries
{
    public class GetGroupByIdQuery : IRequest<DataApiResponse<ViewGroupDto>>
    {
        public GetGroupByIdQuery(Guid id)
            => (Id) = (id);

        public Guid Id { get; set; }


        public class GetGroupByIdQueryHandler : IRequestHandler<GetGroupByIdQuery, DataApiResponse<ViewGroupDto>>
        {
            private readonly IGroupRepository _repository;
            private readonly IMapper _mapper;

            public GetGroupByIdQueryHandler(IGroupRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<DataApiResponse<ViewGroupDto>> Handle(GetGroupByIdQuery request,
                CancellationToken cancellationToken)
            {
                var dto = _mapper.Map<ViewGroupDto>(await _repository.GetByIdAsync(request.Id));
                return new DataApiResponse<ViewGroupDto>(dto);
            }
        }
    }
}
using AutoMapper;
using InstagramClone.Application.ApiResponses;
using InstagramClone.Application.DTOs.Thought.Views;
using InstagramClone.Application.Interfaces.Repository;
using MediatR;

namespace InstagramClone.Application.Features.Thought.Queries
{
    public class GetThoughtByIdQuery : IRequest<DataApiResponse<ViewThoughtDto>>
    {
        public GetThoughtByIdQuery(Guid id)
            => (Id) = (id);

        public Guid Id { get; set; }


        public class GetThoughtByIdQueryHandler : IRequestHandler<GetThoughtByIdQuery, DataApiResponse<ViewThoughtDto>>
        {
            private readonly IThoughtRepository _repository;
            private readonly IMapper _mapper;

            public GetThoughtByIdQueryHandler(IThoughtRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<DataApiResponse<ViewThoughtDto>> Handle(GetThoughtByIdQuery request,
                CancellationToken cancellationToken)
            {
                var dto = _mapper.Map<ViewThoughtDto>(await _repository.GetByIdAsync(request.Id));
                return new DataApiResponse<ViewThoughtDto>(dto);
            }
        }
    }
}
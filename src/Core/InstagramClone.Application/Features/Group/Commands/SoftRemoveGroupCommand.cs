using AutoMapper;
using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.Features.Group.Queries;
using InstagramClone.Application.Interfaces.Repository;
using MediatR;

namespace InstagramClone.Application.Features.Group.Commands
{
    public class SoftRemoveGroupCommand : IRequest<OkApiResponse>
    {
        public SoftRemoveGroupCommand(Guid id)
            => (Id) = (id);

        public Guid Id { get; set; }


        public class SoftRemoveGroupCommandHandler : IRequestHandler<SoftRemoveGroupCommand, OkApiResponse>
        {
            private readonly IGroupRepository _repository;
            private readonly IMediator _mediator;
            private readonly IMapper _mapper;

            public SoftRemoveGroupCommandHandler(IGroupRepository repository, IMediator mediator, IMapper mapper)
                => (_repository, _mediator, _mapper) = (repository, mediator, mapper);

            public async Task<OkApiResponse> Handle(SoftRemoveGroupCommand request, CancellationToken cancellationToken)
            {
                var groupByIdResponse = await _mediator.Send(new GetGroupByIdQuery(request.Id));
                var groupEntityToRemove = _mapper.Map<Domain.Entities.Group>(groupByIdResponse.Data);
                bool isSuccess = await _repository.SoftRemoveAsync(groupEntityToRemove);
                if (!isSuccess)
                    throw new Exception();

                return new OkApiResponse();
            }
        }
    }
}
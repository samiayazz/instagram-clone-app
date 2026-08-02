using AutoMapper;
using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.Features.Thought.Queries;
using InstagramClone.Application.Interfaces.Repository;
using MediatR;

namespace InstagramClone.Application.Features.Thought.Commands
{
    public class RemoveThoughtCommand : IRequest<OkApiResponse>
    {
        public RemoveThoughtCommand(Guid id)
            => (Id) = (id);

        public Guid Id { get; set; }


        public class RemoveThoughtCommandHandler : IRequestHandler<RemoveThoughtCommand, OkApiResponse>
        {
            private readonly IThoughtRepository _repository;
            private readonly IMediator _mediator;
            private readonly IMapper _mapper;

            public RemoveThoughtCommandHandler(IThoughtRepository repository, IMediator mediator, IMapper mapper)
                => (_repository, _mediator, _mapper) = (repository, mediator, mapper);

            public async Task<OkApiResponse> Handle(RemoveThoughtCommand request, CancellationToken cancellationToken)
            {
                var thoughtByIdResponse = await _mediator.Send(new GetThoughtByIdQuery(request.Id));
                var thoughtEntityToRemove = _mapper.Map<Domain.Entities.Thought>(thoughtByIdResponse.Data);
                bool isSuccess = await _repository.RemoveAsync(thoughtEntityToRemove);
                if (!isSuccess)
                    throw new Exception();

                return new OkApiResponse();
            }
        }
    }
}
using AutoMapper;
using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.Features.Identity.Queries;
using InstagramClone.Application.Interfaces.Repository.Identity;
using InstagramClone.Domain.Entities.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Commands
{
    public class RemoveUserCommand : IRequest<OkApiResponse>
    {
        public RemoveUserCommand(Guid id)
            => (Id) = (id);

        public Guid Id { get; set; }


        public class RemoveUserCommandHandler : IRequestHandler<RemoveUserCommand, OkApiResponse>
        {
            private readonly IUserRepository _repository;
            private readonly IMediator _mediator;
            private readonly IMapper _mapper;

            public RemoveUserCommandHandler(IUserRepository repository, IMediator mediator, IMapper mapper)
                => (_repository, _mediator, _mapper) = (repository, mediator, mapper);

            public async Task<OkApiResponse> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
            {
                var userByIdResponse = await _mediator.Send(new GetUserByIdQuery(request.Id));
                var userEntityToRemove = _mapper.Map<AppUser>(userByIdResponse.Data);
                bool isSuccess = await _repository.SoftRemoveAsync(userEntityToRemove);
                if (!isSuccess)
                    throw new Exception();

                return new OkApiResponse();
            }
        }
    }
}
using AutoMapper;
using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.DTOs.Thought.Requests;
using InstagramClone.Application.Interfaces.Repository;
using MediatR;

namespace InstagramClone.Application.Features.Thought.Commands
{
    public class UpdateThoughtCommand : IRequest<OkApiResponse>
    {
        public UpdateThoughtCommand(Guid id, WriteThoughtDto dto)
            => (Id, Dto) = (id, dto);

        public Guid Id { get; set; }
        public WriteThoughtDto Dto { get; set; }


        public class UpdateThoughtCommandHandler : IRequestHandler<UpdateThoughtCommand, OkApiResponse>
        {
            private readonly IThoughtRepository _repository;
            private readonly IMapper _mapper;

            public UpdateThoughtCommandHandler(IThoughtRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<OkApiResponse> Handle(UpdateThoughtCommand request, CancellationToken cancellationToken)
            {
                var entityThoughtToUpdate = _mapper.Map(request.Dto, new Domain.Entities.Thought(request.Id, ""));
                bool isSuccess = await _repository.UpdateAsync(entityThoughtToUpdate);
                if (!isSuccess)
                    throw new Exception();

                return new OkApiResponse();
            }
        }
    }
}
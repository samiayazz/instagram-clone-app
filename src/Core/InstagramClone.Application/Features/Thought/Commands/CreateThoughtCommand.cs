using AutoMapper;
using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.DTOs.Thought.Requests;
using InstagramClone.Application.Interfaces.Repository;
using MediatR;

namespace InstagramClone.Application.Features.Thought.Commands
{
    public class CreateThoughtCommand : IRequest<OkApiResponse>
    {
        public CreateThoughtCommand(WriteThoughtDto dto)
            => (Dto) = (dto);

        public WriteThoughtDto Dto { get; set; }


        public class CreateThoughtCommandHandler : IRequestHandler<CreateThoughtCommand, OkApiResponse>
        {
            private readonly IThoughtRepository _repository;
            private readonly IMapper _mapper;

            public CreateThoughtCommandHandler(IThoughtRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<OkApiResponse> Handle(CreateThoughtCommand request, CancellationToken cancellationToken)
            {
                bool isSuccess = await _repository.CreateAsync(_mapper.Map<Domain.Entities.Thought>(request.Dto));
                if (!isSuccess)
                    throw new Exception();

                return new OkApiResponse();
            }
        }
    }
}
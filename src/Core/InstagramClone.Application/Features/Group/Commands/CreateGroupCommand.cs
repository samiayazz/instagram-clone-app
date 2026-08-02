using AutoMapper;
using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.DTOs.Group.Requests;
using InstagramClone.Application.Interfaces.Repository;
using MediatR;

namespace InstagramClone.Application.Features.Group.Commands
{
    public class CreateGroupCommand : IRequest<OkApiResponse>
    {
        public CreateGroupCommand(WriteGroupDto dto)
            => (Dto) = (dto);

        public WriteGroupDto Dto { get; set; }


        public class CreateGroupCommandHandler : IRequestHandler<CreateGroupCommand, OkApiResponse>
        {
            private readonly IGroupRepository _repository;
            private readonly IMapper _mapper;

            public CreateGroupCommandHandler(IGroupRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<OkApiResponse> Handle(CreateGroupCommand request, CancellationToken cancellationToken)
            {
                bool isSuccess = await _repository.CreateAsync(_mapper.Map<Domain.Entities.Group>(request.Dto));
                if (!isSuccess)
                    throw new Exception();

                return new OkApiResponse();
            }
        }
    }
}
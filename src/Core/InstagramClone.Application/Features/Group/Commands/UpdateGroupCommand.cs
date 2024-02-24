using AutoMapper;
using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.DTOs.Group.Requests;
using InstagramClone.Application.Interfaces.Repository;
using MediatR;

namespace InstagramClone.Application.Features.Group.Commands
{
    public class UpdateGroupCommand : IRequest<OkApiResponse>
    {
        public UpdateGroupCommand(Guid id, WriteGroupDto dto)
            => (Id, Dto) = (id, dto);

        public Guid Id { get; set; }
        public WriteGroupDto Dto { get; set; }


        public class UpdateGroupCommandHandler : IRequestHandler<UpdateGroupCommand, OkApiResponse>
        {
            private readonly IGroupRepository _repository;
            private readonly IMapper _mapper;

            public UpdateGroupCommandHandler(IGroupRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<OkApiResponse> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
            {
                var entityGroupToUpdate = _mapper.Map(request.Dto,
                    new Domain.Entities.Group(request.Id, request.Dto.Name, request.Dto.About));
                bool isSuccess = await _repository.UpdateAsync(entityGroupToUpdate);
                if (!isSuccess)
                    throw new Exception();

                return new OkApiResponse();
            }
        }
    }
}
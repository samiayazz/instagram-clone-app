using AutoMapper;
using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.DTOs.Identity.Requests;
using InstagramClone.Application.Interfaces.Repository.Identity;
using InstagramClone.Domain.Entities.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Commands
{
    public class UpdateUserCommand : IRequest<OkApiResponse>
    {
        public UpdateUserCommand(Guid id, WriteUserDto dto)
            => (Id, Dto) = (id, dto);

        private Guid Id { get; set; }
        private WriteUserDto Dto { get; set; }


        public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, OkApiResponse>
        {
            private readonly IUserRepository _repository;
            private readonly IMapper _mapper;

            public UpdateUserCommandHandler(IUserRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<OkApiResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
            {
                if (!await _repository.IsEmailUniqueAsync(request.Dto.Email))
                    throw new Exception();

                bool isSuccess = await _repository.UpdateAsync(_mapper.Map<AppUser>(request.Dto));
                if (!isSuccess)
                    throw new Exception();

                return new OkApiResponse();
            }
        }
    }
}
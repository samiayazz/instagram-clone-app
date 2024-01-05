using AutoMapper;
using InstagramClone.Application.ApiResponses;
using InstagramClone.Application.DTOs.Identity.Requests;
using InstagramClone.Application.DTOs.Identity.Views;
using InstagramClone.Application.Interfaces.Repository.Identity;
using MediatR;

namespace InstagramClone.Application.Features.Identity.Queries
{
    public class GetUserQuery : IRequest<DataApiResponse<ViewUserDto>>
    {
        public GetUserQuery(GetUserDto dto)
            => (Dto) = (dto);

        public GetUserDto Dto { get; set; }


        public class GetUserQueryHandler : IRequestHandler<GetUserQuery, DataApiResponse<ViewUserDto>>
        {
            private readonly IUserRepository _repository;
            private readonly IMapper _mapper;

            public GetUserQueryHandler(IUserRepository repository, IMapper mapper)
                => (_repository, _mapper) = (repository, mapper);

            public async Task<DataApiResponse<ViewUserDto>> Handle(GetUserQuery request,
                CancellationToken cancellationToken)
            {
                var dto = _mapper.Map<ViewUserDto>(
                    await _repository.GetByUserNameOrEmailAndPasswordAsync(
                        request.Dto.UserNameOrEmail, request.Dto.Password
                    ));

                return new DataApiResponse<ViewUserDto>(dto);
            }
        }
    }
}
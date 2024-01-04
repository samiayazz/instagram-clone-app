using MediatR;

namespace InstagramClone.Application.Features.Queries.GetAllUsers
{
    public class GetUserQueryRequest : IRequest<GetUserQueryResponse>
    {
        public GetUserQueryRequest(string userNameOrEmail, string password)
            => (UserNameOrEmail, Password) = (userNameOrEmail, password);

        public string UserNameOrEmail { get; init; }
        public string Password { get; set; }
    }
}
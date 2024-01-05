using InstagramClone.Application.Interfaces.DTO.Common;

namespace InstagramClone.Application.DTOs.Identity.Requests
{
    public class GetUserDto : IDto
    {
        public GetUserDto(string userNameOrEmail, string password)
            => (UserNameOrEmail, Password) = (userNameOrEmail, password);

        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
using InstagramClone.Application.Interfaces.DTO.Common;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Application.DTOs.Identity
{
    public class GetUserDto : IDto
    {
        public GetUserDto(string userNameOrEmail, string password)
            => (UserNameOrEmail, Password) = (userNameOrEmail, password);

        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
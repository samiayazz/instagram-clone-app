using InstagramClone.Application.Interfaces.DTO.Common;

namespace InstagramClone.Application.DTOs.Identity.Requests
{
    public class WriteUserDto : IDto
    {
        public WriteUserDto(string userName, string email, string password,
            string firstName, string lastName, bool gender, DateTime birthDate, string? about = null)
            => (UserName, Email, Password, FirstName, LastName, Gender, BirthDate, About) =
                (userName, email, password, firstName, lastName, gender, birthDate, about);

        public string UserName { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public bool Gender { get; init; }
        public DateTime BirthDate { get; init; }
        public string? About { get; set; }
    }
}
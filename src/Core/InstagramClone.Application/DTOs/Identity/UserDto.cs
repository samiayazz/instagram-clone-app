using InstagramClone.Application.Interfaces.DTO.Common;

namespace InstagramClone.Application.DTOs.Identity
{
    public class UserDto : IDto
    {
        public UserDto(Guid id, string userName, string email, string password,
            string firstName, string lastName, bool gender, DateTime birthDate,
            DateTime createdDate, DateTime? updatedDate = null, string? about = null)
            => (Id, UserName, Email, Password, FirstName, LastName, Gender, BirthDate,
                    CreatedDate, UpdatedDate, About)
                = (id, userName, email, password, firstName, lastName, gender, birthDate,
                    createdDate, updatedDate, about);

        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? About { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
using InstagramClone.Domain.Interfaces.Base;
using Microsoft.AspNetCore.Identity;

namespace InstagramClone.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>, IEntity
    {
        public AppUser(Guid id, string userName, string email, string passwordHash,
            string firstName, string lastName, bool gender, DateTime birthDate)
            => (Id, base.UserName, base.Email, base.PasswordHash, FirstName, LastName, Gender, BirthDate) =
                (id, userName, email, passwordHash, firstName, lastName, gender, birthDate);

        public new Guid Id { get; private init; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? About { get; set; }

        public DateTime CreatedDate { get; private init; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? RemovedDate { get; set; }
    }
}
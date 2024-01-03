using InstagramClone.Domain.Interfaces.Base;
using Microsoft.AspNetCore.Identity;

namespace InstagramClone.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>, IEntity
    {
        public AppUser(string userName, string email, string passwordHash,
            string firstName, string lastName, bool gender, DateTime birthDate)
            => (base.UserName, base.Email, base.PasswordHash, FirstName, LastName, Gender, BirthDate) =
                (userName, email, passwordHash, firstName, lastName, gender, birthDate);

        public AppUser(Guid id, string userName, string email, string passwordHash,
            string firstName, string lastName, bool gender, DateTime birthDate)
            => (Id, base.UserName, base.Email, base.PasswordHash, FirstName, LastName, Gender, BirthDate) =
                (id, userName, email, passwordHash, firstName, lastName, gender, birthDate);

        public new Guid Id { get; private init; } = Guid.NewGuid();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string? About { get; set; }

        public DateTime CreatedDate { get; private set; } = default!;
        public DateTime? UpdatedDate { get; private set; } = default!;
        public DateTime? RemovedDate { get; private set; } = default!;
        public bool IsRemoved { get; set; }
    }
}
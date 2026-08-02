using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Tests.UnitTests.Core.DomainTests
{
    public class IdentityTests
    {
        /*  public AppUser(Guid id, string userName, string email, string passwordHash,
            string firstName, string lastName, bool gender, DateTime birthDate)
            => (Id, base.UserName, base.Email, base.PasswordHash, FirstName, LastName, Gender, BirthDate) =
                (id, userName, email, passwordHash, firstName, lastName, gender, birthDate);  */
        [Fact]
        public void Create_Should_ThrowException_When_IdIsEmpty()
            => Assert.Throws<Exception>(
                () => new AppUser(Guid.Empty, "UserName", "test@gmail.com", "password",
                    "First Name", "Last Name", false, DateTime.UtcNow));

        #region UserName

        [Fact]
        public void Create_Should_ThrowException_When_UserNameIsNull()
            => Assert.Throws<Exception>(
                () => new AppUser(null!, "test@gmail.com", "password",
                    "First Name", "Last Name", false, DateTime.UtcNow));

        [Fact]
        public void Create_Should_ThrowException_When_UserNameIsEmpty()
            => Assert.Throws<Exception>(
                () => new AppUser("", "test@gmail.com", "password",
                    "First Name", "Last Name", false, DateTime.UtcNow));

        [Fact]
        public void Create_Should_ThrowException_When_UserNameGreaterThan50()
        {
            // Arrange
            string userName = "";
            for (int i = 1; i <= 51; i++)
                userName += "x";

            // Assert
            Assert.Throws<Exception>(
                () => new AppUser(userName, "test@gmail.com", "password",
                    "First Name", "Last Name", false, DateTime.UtcNow));
        }

        #endregion

        #region Email

        [Fact]
        public void Create_Should_ThrowException_When_EmailIsNull()
            => Assert.Throws<Exception>(
                () => new AppUser("UserName", null!, "password",
                    "First Name", "Last Name", false, DateTime.UtcNow));

        [Fact]
        public void Create_Should_ThrowException_When_EmailIsEmpty()
            => Assert.Throws<Exception>(
                () => new AppUser("UserName", "", "password",
                    "First Name", "Last Name", false, DateTime.UtcNow));

        [Fact]
        public void Create_Should_ThrowException_When_UserNameGreaterThan254()
        {
            // Arrange
            string email = "";
            for (int i = 1; i <= 255; i++)
                email += "x";

            // Assert
            Assert.Throws<Exception>(
                () => new AppUser("UserName", email, "password",
                    "First Name", "Last Name", false, DateTime.UtcNow));
        }

        [Fact]
        public void Create_Should_ThrowException_When_EmailIsNotCorrect()
            => Assert.Throws<Exception>(
                () => new AppUser("UserName", "test", "password",
                    "First Name", "Last Name", false, DateTime.UtcNow));

        #endregion

        #region Password

        [Fact]
        public void Create_Should_ThrowException_When_PasswordIsNull()
            => Assert.Throws<Exception>(
                () => new AppUser("UserName", "test@gmail.com", null!,
                    "First Name", "Last Name", false, DateTime.UtcNow));

        [Fact]
        public void Create_Should_ThrowException_When_PasswordIsEmpty()
            => Assert.Throws<Exception>(
                () => new AppUser("UserName", "test@gmail.com", "",
                    "First Name", "Last Name", false, DateTime.UtcNow));

        #endregion

        #region FirstName

        [Fact]
        public void Create_Should_ThrowException_When_FirstNameIsNull()
            => Assert.Throws<Exception>(
                () => new AppUser("UserName", "test@gmail.com", "password",
                    null!, "Last Name", false, DateTime.UtcNow));

        [Fact]
        public void Create_Should_ThrowException_When_FirstNameIsEmpty()
            => Assert.Throws<Exception>(
                () => new AppUser("UserName", "test@gmail.com", "password",
                    "", "Last Name", false, DateTime.UtcNow));

        [Fact]
        public void Create_Should_ThrowException_When_FirstNameGreaterThan25()
        {
            // Arrange
            string firstName = "";
            for (int i = 1; i <= 26; i++)
                firstName += "x";

            // Assert
            Assert.Throws<Exception>(
                () => new AppUser("UserName", "test@gmail.com", "password",
                    firstName, "Last Name", false, DateTime.UtcNow));
        }

        #endregion

        #region LastName

        [Fact]
        public void Create_Should_ThrowException_When_LastNameIsNull()
            => Assert.Throws<Exception>(
                () => new AppUser("UserName", "test@gmail.com", "password",
                    "First Name", null!, false, DateTime.UtcNow));

        [Fact]
        public void Create_Should_ThrowException_When_LastNameIsEmpty()
            => Assert.Throws<Exception>(
                () => new AppUser("UserName", "test@gmail.com", "password",
                    "FirstName", "", false, DateTime.UtcNow));

        [Fact]
        public void Create_Should_ThrowException_When_LastNameGreaterThan25()
        {
            // Arrange
            string lastName = "";
            for (int i = 1; i <= 26; i++)
                lastName += "x";

            // Assert
            Assert.Throws<Exception>(
                () => new AppUser("UserName", "test@gmail.com", "password",
                    "First Name", lastName, false, DateTime.UtcNow));
        }

        #endregion
    }
}
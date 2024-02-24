using InstagramClone.Domain.Entities;

namespace InstagramClone.Tests.UnitTests.Core.DomainTests
{
    public class GroupTests
    {
        [Fact]
        public void Create_Should_ThrowException_When_IdIsEmpty()
            => Assert.Throws<Exception>(
                () => new Group(Guid.Empty, "Group name", "Group about"));

        #region Name

        [Fact]
        public void Create_Should_ThrowException_When_NameIsNull()
            => Assert.Throws<Exception>(
                () => new Group(null!, "Group about"));

        [Fact]
        public void Create_Should_ThrowException_When_NameIsEmpty()
            => Assert.Throws<Exception>(
                () => new Group("", "Group about"));

        [Fact]
        public void Create_Should_ThrowException_When_NameGreaterThan50()
        {
            // Arrange
            string name = "";
            for (int i = 1; i <= 51; i++)
                name += "x";

            // Assert
            Assert.Throws<Exception>(
                () => new Group(name, "Group about"));
        }

        #endregion

        #region About

        [Fact]
        public void Create_Should_ThrowException_When_AboutIsNull()
            => Assert.Throws<Exception>(
                () => new Group("Group name", null!));

        [Fact]
        public void Create_Should_ThrowException_When_AboutIsEmpty()
            => Assert.Throws<Exception>(
                () => new Group("Group name", ""));

        [Fact]
        public void Create_Should_ThrowException_When_AboutGreaterThan500()
        {
            // Arrange
            string about = "";
            for (int i = 1; i <= 501; i++)
                about += "x";

            // Assert
            Assert.Throws<Exception>(
                () => new Group("Group name", about));
        }

        #endregion

        [Fact]
        public void Create_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var group = new Group("Group name", "Group about");

            // Assert
            Assert.True(group != null);
        }
    }
}
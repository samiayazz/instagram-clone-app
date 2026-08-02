using InstagramClone.Domain.Entities;

namespace InstagramClone.Tests.UnitTests.Core.DomainTests
{
    public class ThoughtTests
    {
        [Fact]
        public void Create_Should_ThrowException_When_IdIsEmpty()
            => Assert.Throws<Exception>(
                () => new Thought(Guid.Empty, "My thought!"));

        [Fact]
        public void Create_Should_ThrowException_When_TextIsNull()
            => Assert.Throws<Exception>(
                () => new Thought(null!));

        [Fact]
        public void Create_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => new Thought(""));

        [Fact]
        public void Create_Should_ThrowException_When_TextGreaterThan150()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 151; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => new Thought(text));
        }

        [Fact]
        public void Create_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var thought = new Thought("My thought!");

            // Assert
            Assert.True(thought != null);
        }
    }
}
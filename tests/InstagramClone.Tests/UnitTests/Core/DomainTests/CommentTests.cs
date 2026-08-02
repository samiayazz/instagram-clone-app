using InstagramClone.Domain.Entities.Content;

namespace InstagramClone.Tests.UnitTests.Core.DomainTests
{
    public class CommentTests
    {
        #region Comment

        [Fact]
        public void Create_Should_ThrowException_When_IdIsEmpty()
            => Assert.Throws<Exception>(
                () => new Comment(Guid.Empty, Guid.NewGuid(), "Comment text."));

        [Fact]
        public void Create_Should_ThrowException_When_PostIdIsEmpty()
            => Assert.Throws<Exception>(
                () => new Comment(Guid.Empty, "Comment text."));

        [Fact]
        public void Create_Should_ThrowException_When_TextIsNull()
            => Assert.Throws<Exception>(
                () => new Comment(Guid.NewGuid(), null!));

        [Fact]
        public void Create_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => new Comment(Guid.NewGuid(), ""));

        [Fact]
        public void Create_Should_ThrowException_When_TextGreaterThan500()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 501; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => new Comment(Guid.NewGuid(), text));
        }

        [Fact]
        public void Create_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var comment = new Comment(Guid.NewGuid(), "Comment text.");

            // Assert
            Assert.True(comment != null);
        }

        #endregion

        #region Reply

        [Fact]
        public void CreateReply_Should_ThrowException_When_IdIsEmpty()
            => Assert.Throws<Exception>(
                () => new CommentReply(Guid.Empty,
                    Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid()));

        [Fact]
        public void CreateReply_Should_ThrowException_When_RepliedCommentIdIsEmpty()
            => Assert.Throws<Exception>(
                () => new CommentReply(Guid.Empty, Guid.NewGuid(), Guid.NewGuid()));

        [Fact]
        public void CreateReply_Should_ThrowException_When_RecipientIdIsEmpty()
            => Assert.Throws<Exception>(
                () => new CommentReply(Guid.NewGuid(), Guid.Empty, Guid.NewGuid()));

        [Fact]
        public void CreateReply_Should_ThrowException_When_CommentIdIsEmpty()
            => Assert.Throws<Exception>(
                () => new CommentReply(Guid.NewGuid(), Guid.NewGuid(), Guid.Empty));

        [Fact]
        public void CreateReply_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var reply = new CommentReply(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());

            // Assert
            Assert.True(reply != null);
        }

        #endregion
    }
}
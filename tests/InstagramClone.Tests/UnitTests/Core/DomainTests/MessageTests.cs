using InstagramClone.Domain.Entities.Chat;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Tests.UnitTests.Core.DomainTests
{
    public class MessageTests
    {
        #region Message

        #region DirectMessage

        #region VideoMessage

        [Fact]
        public void CreateDirectVideo_Should_ThrowException_When_VideoPathIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Direct, null!));

        [Fact]
        public void CreateDirectVideo_Should_ThrowException_When_VideoPathIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Direct, ""));

        [Fact]
        public void CreateDirectVideo_Should_ThrowException_When_VideoPathGreaterThan150()
        {
            // Arrange
            string videoPath = "";
            for (int i = 1; i <= 151; i++)
                videoPath += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Direct, videoPath));
        }

        [Fact]
        public void CreateDirectVideo_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Direct, "Video Path", ""));

        [Fact]
        public void CreateDirectVideo_Should_ThrowException_When_TextGreaterThan500()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 501; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Direct, "Video Path", text));
        }

        [Fact]
        public void CreateDirectVideo_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var directVideoMessage = Message.CreateVideoMessage(MessageType.Direct, "Video Path", "Text");

            // Assert
            Assert.True(directVideoMessage != null);
        }

        #endregion

        #region ImageMessage

        [Fact]
        public void CreateDirectImage_Should_ThrowException_When_ImagePathIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Direct, null!));

        [Fact]
        public void CreateDirectImage_Should_ThrowException_When_ImagePathIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Direct, ""));

        [Fact]
        public void CreateDirectImage_Should_ThrowException_When_ImagePathGreaterThan150()
        {
            // Arrange
            string imagePath = "";
            for (int i = 1; i <= 151; i++)
                imagePath += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Direct, imagePath));
        }

        [Fact]
        public void CreateDirectImage_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Direct, "Image Path", ""));

        [Fact]
        public void CreateDirectImage_Should_ThrowException_When_TextGreaterThan500()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 501; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Direct, "Image Path", text));
        }

        [Fact]
        public void CreateDirectImage_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var directImageMessage = Message.CreateImageMessage(MessageType.Direct, "Image Path", "Text");

            // Assert
            Assert.True(directImageMessage != null);
        }

        #endregion

        #region SoundMessage

        [Fact]
        public void CreateDirectSound_Should_ThrowException_When_SoundPathIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Direct, null!));

        [Fact]
        public void CreateDirectSound_Should_ThrowException_When_SoundPathIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Direct, ""));

        [Fact]
        public void CreateDirectSound_Should_ThrowException_When_SoundPathGreaterThan150()
        {
            // Arrange
            string soundPath = "";
            for (int i = 1; i <= 151; i++)
                soundPath += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Direct, soundPath));
        }

        [Fact]
        public void CreateDirectSound_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Direct, "Sound Path", ""));

        [Fact]
        public void CreateDirectSound_Should_ThrowException_When_TextGreaterThan500()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 501; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Direct, "Sound Path", text));
        }

        [Fact]
        public void CreateDirectSound_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var directSoundMessage = Message.CreateSoundMessage(MessageType.Direct, "Sound Path", "Text");

            // Assert
            Assert.True(directSoundMessage != null);
        }

        #endregion

        #region TextMessage

        [Fact]
        public void CreateDirectText_Should_ThrowException_When_TextIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateTextMessage(MessageType.Direct, null!));

        [Fact]
        public void CreateDirectText_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateTextMessage(MessageType.Direct, ""));

        [Fact]
        public void CreateDirectText_Should_ThrowException_When_TextGreaterThan500()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 501; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateTextMessage(MessageType.Direct, text));
        }

        [Fact]
        public void CreateDirectText_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var directTextMessage = Message.CreateTextMessage(MessageType.Direct, "Text");

            // Assert
            Assert.True(directTextMessage != null);
        }

        #endregion

        #region EmojiMessage

        [Fact]
        public void CreateDirectEmoji_Should_ThrowException_When_EmojiIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateEmojiMessage(MessageType.Direct, null!));

        [Fact]
        public void CreateDirectEmoji_Should_ThrowException_When_EmojiIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateEmojiMessage(MessageType.Direct, ""));

        [Fact]
        public void CreateDirectEmoji_Should_ThrowException_When_EmojiGreaterThan500()
        {
            // Arrange
            string emoji = "";
            for (int i = 1; i <= 501; i++)
                emoji += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateEmojiMessage(MessageType.Direct, emoji));
        }

        [Fact]
        public void CreateDirectEmoji_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var directEmojiMessage = Message.CreateEmojiMessage(MessageType.Direct, "Emoji");

            // Assert
            Assert.True(directEmojiMessage != null);
        }

        #endregion

        #endregion

        #region GroupMessage

        #region VideoMessage

        [Fact]
        public void CreateGroupVideo_Should_ThrowException_When_VideoPathIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Group, null!));

        [Fact]
        public void CreateGroupVideo_Should_ThrowException_When_VideoPathIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Group, ""));

        [Fact]
        public void CreateGroupVideo_Should_ThrowException_When_VideoPathGreaterThan150()
        {
            // Arrange
            string videoPath = "";
            for (int i = 1; i <= 151; i++)
                videoPath += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Group, videoPath));
        }

        [Fact]
        public void CreateGroupVideo_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Group, "Video Path", ""));

        [Fact]
        public void CreateGroupVideo_Should_ThrowException_When_TextGreaterThan500()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 501; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateVideoMessage(MessageType.Group, "Video Path", text));
        }

        [Fact]
        public void CreateGroupVideo_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var groupVideoMessage = Message.CreateVideoMessage(MessageType.Group, "Video Path", "Text");

            // Assert
            Assert.True(groupVideoMessage != null);
        }

        #endregion

        #region ImageMessage

        [Fact]
        public void CreateGroupImage_Should_ThrowException_When_ImagePathIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Group, null!));

        [Fact]
        public void CreateGroupImage_Should_ThrowException_When_ImagePathIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Group, ""));

        [Fact]
        public void CreateGroupImage_Should_ThrowException_When_ImagePathGreaterThan150()
        {
            // Arrange
            string imagePath = "";
            for (int i = 1; i <= 151; i++)
                imagePath += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Group, imagePath));
        }

        [Fact]
        public void CreateGroupImage_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Group, "Image Path", ""));

        [Fact]
        public void CreateGroupImage_Should_ThrowException_When_TextGreaterThan500()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 501; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateImageMessage(MessageType.Group, "Image Path", text));
        }

        [Fact]
        public void CreateGroupImage_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var groupImageMessage = Message.CreateImageMessage(MessageType.Group, "Image Path", "Text");

            // Assert
            Assert.True(groupImageMessage != null);
        }

        #endregion

        #region SoundMessage

        [Fact]
        public void CreateGroupSound_Should_ThrowException_When_SoundPathIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Group, null!));

        [Fact]
        public void CreateGroupSound_Should_ThrowException_When_SoundPathIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Group, ""));

        [Fact]
        public void CreateGroupSound_Should_ThrowException_When_SoundPathGreaterThan150()
        {
            // Arrange
            string soundPath = "";
            for (int i = 1; i <= 151; i++)
                soundPath += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Group, soundPath));
        }

        [Fact]
        public void CreateGroupSound_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Group, "Sound Path", ""));

        [Fact]
        public void CreateGroupSound_Should_ThrowException_When_TextGreaterThan500()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 501; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateSoundMessage(MessageType.Group, "Sound Path", text));
        }

        [Fact]
        public void CreateGroupSound_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var groupSoundMessage = Message.CreateSoundMessage(MessageType.Group, "Sound Path", "Text");

            // Assert
            Assert.True(groupSoundMessage != null);
        }

        #endregion

        #region TextMessage

        [Fact]
        public void CreateGroupText_Should_ThrowException_When_TextIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateTextMessage(MessageType.Group, null!));

        [Fact]
        public void CreateGroupText_Should_ThrowException_When_TextIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateTextMessage(MessageType.Group, ""));

        [Fact]
        public void CreateGroupText_Should_ThrowException_When_TextGreaterThan500()
        {
            // Arrange
            string text = "";
            for (int i = 1; i <= 501; i++)
                text += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateTextMessage(MessageType.Group, text));
        }

        [Fact]
        public void CreateGroupText_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var groupTextMessage = Message.CreateTextMessage(MessageType.Group, "Text");

            // Assert
            Assert.True(groupTextMessage != null);
        }

        #endregion

        #region EmojiMessage

        [Fact]
        public void CreateGroupEmoji_Should_ThrowException_When_EmojiIsNull()
            => Assert.Throws<Exception>(
                () => Message.CreateEmojiMessage(MessageType.Group, null!));

        [Fact]
        public void CreateGroupEmoji_Should_ThrowException_When_EmojiIsEmpty()
            => Assert.Throws<Exception>(
                () => Message.CreateEmojiMessage(MessageType.Group, ""));

        [Fact]
        public void CreateGroupEmoji_Should_ThrowException_When_EmojiGreaterThan500()
        {
            // Arrange
            string emoji = "";
            for (int i = 1; i <= 501; i++)
                emoji += "x";

            // Assert
            Assert.Throws<Exception>(
                () => Message.CreateEmojiMessage(MessageType.Group, emoji));
        }

        [Fact]
        public void CreateGroupEmoji_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var groupEmojiMessage = Message.CreateEmojiMessage(MessageType.Group, "Emoji");

            // Assert
            Assert.True(groupEmojiMessage != null);
        }

        #endregion

        #endregion

        #endregion

        #region Reply

        [Fact]
        public void CreateReply_Should_ThrowException_When_IdIsEmpty()
            => Assert.Throws<Exception>(
                () => new MessageReply(Guid.Empty, Guid.NewGuid(), Guid.NewGuid()));

        [Fact]
        public void CreateReply_Should_ThrowException_When_RepliedMessageIdIsEmpty()
            => Assert.Throws<Exception>(
                () => new MessageReply(Guid.Empty, Guid.NewGuid()));

        [Fact]
        public void CreateReply_Should_ThrowException_When_MessageIdIsEmpty()
            => Assert.Throws<Exception>(
                () => new MessageReply(Guid.NewGuid(), Guid.Empty));

        [Fact]
        public void CreateReply_Should_BeSuccess_When_AllParamsAreCorrect()
        {
            // Arrange
            var reply = new MessageReply(Guid.NewGuid(), Guid.NewGuid());

            // Assert
            Assert.True(reply != null);
        }

        #endregion
    }
}
using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Chat
{
    public class Message : ModifiableEntityBase
    {
        private Message(Guid id, Guid createdById,
            MessageType type, MessageContentType contentType, bool isReply = false)
            : base(id, createdById)
            => (Type, ContentType, IsReply) = (type, contentType, isReply);

        public bool IsReply { get; private init; }
        public MessageType Type { get; private init; }
        public MessageContentType ContentType { get; private init; }

        public string? VideoPath { get; private init; }
        public string? ImagePath { get; private init; }
        public string? SoundPath { get; private init; }
        public string? Text { get; private init; }
        public string? Emoji { get; private init; }

        public Guid? RecipientId { get; private init; }
        public virtual AppUser? Recipient { get; private set; }

        public Guid? GroupId { get; private init; }
        public virtual Group? Group { get; private set; }

        public virtual IEnumerable<AppUser> LikedUsers { get; private set; } = default!;

        public static Message CreateVideoMessage(Guid id, Guid createdById, MessageType type,
            string videoPath, string? text = null, bool isReply = false)
            => type switch
            {
                MessageType.Direct => new(id, createdById, type, MessageContentType.Video, isReply)
                {
                    RecipientId = Guid.NewGuid(),
                    VideoPath = videoPath,
                    Text = text
                },
                MessageType.Group => new(id, createdById, type, MessageContentType.Video, isReply)
                {
                    GroupId = Guid.NewGuid(),
                    VideoPath = videoPath,
                    Text = text
                },

                _ => throw new Exception("MessageType: 'Direct' ya da 'Group' olarak belirlenmelidir.")
            };

        public static Message CreateImageMessage(Guid id, Guid createdById, MessageType type,
            string imagePath, string? text = null, bool isReply = false)
            => type switch
            {
                MessageType.Direct => new(id, createdById, type, MessageContentType.Image, isReply)
                {
                    RecipientId = Guid.NewGuid(),
                    ImagePath = imagePath,
                    Text = text
                },
                MessageType.Group => new(id, createdById, type, MessageContentType.Image, isReply)
                {
                    GroupId = Guid.NewGuid(),
                    ImagePath = imagePath,
                    Text = text
                },

                _ => throw new Exception("MessageType: 'Direct' ya da 'Group' olarak belirlenmelidir.")
            };

        public static Message CreateSoundMessage(Guid id, Guid createdById, MessageType type,
            string soundPath, string? text = null, bool isReply = false)
            => type switch
            {
                MessageType.Direct => new(id, createdById, type, MessageContentType.Sound, isReply)
                {
                    RecipientId = Guid.NewGuid(),
                    SoundPath = soundPath,
                    Text = text
                },
                MessageType.Group => new(id, createdById, type, MessageContentType.Sound, isReply)
                {
                    GroupId = Guid.NewGuid(),
                    SoundPath = soundPath,
                    Text = text
                },

                _ => throw new Exception("MessageType: 'Direct' ya da 'Group' olarak belirlenmelidir.")
            };

        public static Message CreateTextMessage(Guid id, Guid createdById, MessageType type,
            string? text = null, bool isReply = false)
            => type switch
            {
                MessageType.Direct => new(id, createdById, type, MessageContentType.Text, isReply)
                {
                    RecipientId = Guid.NewGuid(),
                    Text = text
                },
                MessageType.Group => new(id, createdById, type, MessageContentType.Text, isReply)
                {
                    GroupId = Guid.NewGuid(),
                    Text = text
                },

                _ => throw new Exception("MessageType: 'Direct' ya da 'Group' olarak belirlenmelidir.")
            };

        public static Message CreateEmojiMessage(Guid id, Guid createdById, MessageType type,
            string? emoji = null, bool isReply = false)
            => type switch
            {
                MessageType.Direct => new(id, createdById, type, MessageContentType.Emoji, isReply)
                {
                    RecipientId = Guid.NewGuid(),
                    Emoji = emoji
                },
                MessageType.Group => new(id, createdById, type, MessageContentType.Emoji, isReply)
                {
                    GroupId = Guid.NewGuid(),
                    Emoji = emoji
                },

                _ => throw new Exception("MessageType: 'Direct' ya da 'Group' olarak belirlenmelidir.")
            };
    }
}
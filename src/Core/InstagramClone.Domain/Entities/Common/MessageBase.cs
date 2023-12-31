using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Common
{
    public class MessageBase<T> : ModifiableEntityBase where T : class
    {
        protected MessageBase(Guid id, Guid createdById, MessageType type) : base(id, createdById)
            => Type = type;

        public MessageType Type { get; protected set; }
        public string? VideoPath { get; protected set; }
        public string? ImagePath { get; protected set; }
        public string? SoundPath { get; protected set; }
        public string? Text { get; protected set; }
        public string? Emoji { get; protected set; }

        public Guid? ParentId { get; protected set; }
        public virtual T? Parent { get; protected set; }
        public virtual IEnumerable<T>? Replies { get; set; }

        public virtual IEnumerable<AppUser> LikedUsers { get; protected set; }

        public static MessageBase<T> CreateVideoMessage(Guid id, Guid createdById, string videoPath,
            string? text = null)
            => new(id, createdById, MessageType.Video)
            {
                VideoPath = videoPath,
                Text = text
            };

        public static MessageBase<T> CreateImageMessage(Guid id, Guid createdById, string imagePath,
            string? text = null)
            => new(id, createdById, MessageType.Image)
            {
                ImagePath = imagePath,
                Text = text
            };

        public static MessageBase<T> CreateSoundMessage(Guid id, Guid createdById, string soundPath,
            string? text = null)
            => new(id, createdById, MessageType.Sound)
            {
                SoundPath = soundPath,
                Text = text
            };

        public static MessageBase<T> CreateTextMessage(Guid id, Guid createdById, string text)
            => new(id, createdById, MessageType.Text)
            {
                Text = text
            };

        public static MessageBase<T> CreateEmojiMessage(Guid id, Guid createdById, string emoji)
            => new(id, createdById, MessageType.Emoji)
            {
                Emoji = emoji
            };
    }
}
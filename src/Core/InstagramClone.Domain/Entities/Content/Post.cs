using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Content
{
    public class Post : ModifiableEntityBase
    {
        private Post(PostType type, PostContentType contentType, string description)
            => (ContentType, Type, Description) = (contentType, type, description);

        private Post(Guid id, PostType type, PostContentType contentType, string description) : base(id)
            => (ContentType, Type, Description) = (contentType, type, description);

        public PostType Type { get; private init; }
        public PostContentType ContentType { get; private init; }

        public string? VideoPath { get; private init; }
        public string? ImagePath { get; private init; }
        public string? SoundPath { get; private init; }
        public string Description { get; private init; }

        public virtual IEnumerable<Comment> Comments { get; private set; } = default!;

        public virtual IEnumerable<AppUser> LikedUsers { get; private set; } = default!;

        public static Post CreateVideoPost(PostType type, string description, string videoPath)
            => new(type, PostContentType.Video, description)
            {
                VideoPath = videoPath,
            };

        public static Post CreateImagePost(PostType type, string description, string imagePath,
            string? soundPath = null)
            => new(type, PostContentType.Image, description)
            {
                ImagePath = imagePath,
                SoundPath = soundPath
            };

        public static Post CreateSoundPost(PostType type, string description, string soundPath)
            => new(type, PostContentType.Sound, description)
            {
                SoundPath = soundPath,
            };

        public static Post CreateTextPost(PostType type, string description)
            => new(type, PostContentType.Text, description);
    }
}
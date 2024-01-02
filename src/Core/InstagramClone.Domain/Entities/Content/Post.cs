using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Content
{
    public class Post : ModifiableEntityBase
    {
        private Post(Guid id, Guid createdById,
            PostType type, PostContentType contentType, string description)
            : base(id, createdById)
            => (ContentType, Type, Description) = (contentType, type, description);

        public PostType Type { get; private init; }
        public PostContentType ContentType { get; private init; }

        public string? VideoPath { get; private init; }
        public string? ImagePath { get; private init; }
        public string? SoundPath { get; private init; }
        public string Description { get; private init; }

        public virtual IEnumerable<Comment> Comments { get; private set; } = default!;

        public virtual IEnumerable<AppUser> LikedUsers { get; private set; } = default!;

        public static Post CreateVideoPost(Guid id, Guid createdById, PostType type,
            string description, string videoPath)
            => new(id, createdById, type, PostContentType.Video, description)
            {
                VideoPath = videoPath,
            };

        public static Post CreateImagePost(Guid id, Guid createdById, PostType type,
            string description, string imagePath, string? soundPath = null)
            => new(id, createdById, type, PostContentType.Image, description)
            {
                ImagePath = imagePath,
                SoundPath = soundPath
            };

        public static Post CreateSoundPost(Guid id, Guid createdById, PostType type,
            string description, string soundPath)
            => new(id, createdById, type, PostContentType.Sound, description)
            {
                SoundPath = soundPath,
            };

        public static Post CreateTextPost(Guid id, Guid createdById, PostType type,
            string description)
            => new(id, createdById, type, PostContentType.Text, description);
    }
}
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities.Common
{
    public class PostBase<TComment> : ModifiableEntityBase where TComment : class
    {
        protected PostBase(Guid id, Guid createdById, PostType type, string description) : base(id, createdById)
            => (Type, Description) = (type, description);

        public PostType Type { get; protected set; }
        public string? VideoPath { get; protected set; }
        public string? ImagePath { get; protected set; }
        public string? SoundPath { get; protected set; }
        public string Description { get; protected set; }

        public virtual IEnumerable<TComment> Comments { get; protected set; }

        public virtual IEnumerable<AppUser> LikedUsers { get; protected set; }

        public static PostBase<TComment> CreateVideoPost(Guid id, Guid createdById, string description,
            string videoPath)
            => new(id, createdById, PostType.Video, description)
            {
                VideoPath = videoPath,
            };

        public static PostBase<TComment> CreateImagePost(Guid id, Guid createdById, string description,
            string imagePath,
            string? soundPath = null)
            => new(id, createdById, PostType.Image, description)
            {
                ImagePath = imagePath,
                SoundPath = soundPath
            };

        public static PostBase<TComment> CreateSoundPost(Guid id, Guid createdById, string description,
            string soundPath)
            => new(id, createdById, PostType.Sound, description)
            {
                SoundPath = soundPath,
            };

        public static PostBase<TComment> CreateTextPost(Guid id, Guid createdById, string description)
            => new(id, createdById, PostType.Text, description);
    }
}
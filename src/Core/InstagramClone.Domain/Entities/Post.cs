using InstagramClone.Domain.Entities.Common;
using InstagramClone.Domain.Enums;

namespace InstagramClone.Domain.Entities
{
    public class Post : ModifiableEntity
    {
        protected Post(Guid id, Guid createdById, PostType type, string description) : base(id, createdById)
            => (Type, Description) = (type, description);

        public PostType Type { get; protected set; }
        public string Description { get; protected set; }
        public string? VideoPath { get; protected set; }
        public string? ImagePath { get; protected set; }

        public static Post CreateVideoPost(Guid id, Guid createdById, string description, string videoPath)
            => new(id, createdById, PostType.Video, description)
            {
                VideoPath = videoPath,
            };

        public static Post CreateImagePost(Guid id, Guid createdById, string description, string imagePath)
            => new(id, createdById, PostType.Image, description)
            {
                ImagePath = imagePath,
            };

        public static Post CreateTextPost(Guid id, Guid createdById, string description)
            => new(id, createdById, PostType.Text, description);
    }
}
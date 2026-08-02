using InstagramClone.Domain.Entities.Content;
using InstagramClone.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations.Content
{
    public class PostConfiguration : ModifiableEntityConfiguration<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> builder)
        {
            ConfigureRelationships(builder);

            // Enums
            builder.Property(x => x.Type)
                .IsRequired();
            builder.Property(x => x.ContentType)
                .IsRequired();

            // Paths
            builder.Property(x => x.VideoPath)
                .HasMaxLength(150)
                .IsRequired(false);
            builder.Property(x => x.ImagePath)
                .HasMaxLength(150)
                .IsRequired(false);
            builder.Property(x => x.SoundPath)
                .HasMaxLength(150)
                .IsRequired(false);
            // Description
            builder.Property(x => x.Description)
                .HasMaxLength(150)
                .IsRequired();
        }

        private void ConfigureRelationships(EntityTypeBuilder<Post> builder)
        {
            // Comments
            builder.HasMany(p => p.Comments)
                .WithOne(c => c.Post)
                .HasForeignKey(c => c.PostId)
                .IsRequired();

            // LikedUsers
            builder.HasMany(p => p.LikedUsers)
                .WithMany();
        }
    }
}
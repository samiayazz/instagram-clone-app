using InstagramClone.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations.Content
{
    public class CommentConfiguration : ModifiableEntityConfiguration<Domain.Entities.Content.Comment>
    {
        public override void Configure(EntityTypeBuilder<Domain.Entities.Content.Comment> builder)
        {
            ConfigureRelationships(builder);

            // Enums
            builder.Property(x => x.IsReply)
                .HasDefaultValue(false)
                .IsRequired();

            // Text
            builder.Property(x => x.Text)
                .HasMaxLength(500)
                .IsRequired();
        }

        private void ConfigureRelationships(EntityTypeBuilder<Domain.Entities.Content.Comment> builder)
        {
            // Post
            builder.HasOne(c => c.Post)
                .WithMany(p => p.Comments)
                .HasForeignKey(c => c.PostId)
                .IsRequired();

            // LikedUsers
            builder.HasMany(c => c.LikedUsers)
                .WithMany();
        }
    }
}
using InstagramClone.Domain.Entities.Chat;
using InstagramClone.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations.Chat
{
    public class MessageConfiguration : ModifiableEntityConfiguration<Message>
    {
        public override void Configure(EntityTypeBuilder<Message> builder)
        {
            ConfigureRelationships(builder);

            // Enums
            builder.Property(x => x.IsReply)
                .HasDefaultValue(false)
                .IsRequired();
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
            // Text
            builder.Property(x => x.Text)
                .HasMaxLength(500)
                .IsRequired(false);
            // Emoji
            builder.Property(x => x.Emoji)
                .HasMaxLength(500)
                .IsRequired(false);
        }

        private void ConfigureRelationships(EntityTypeBuilder<Message> builder)
        {
            // Recipient
            builder.HasOne(m => m.Recipient)
                .WithMany()
                .HasForeignKey(m => m.RecipientId)
                .IsRequired(false);

            // Group
            builder.HasOne(m => m.Group)
                .WithMany(g => g.Messages)
                .HasForeignKey(m => m.GroupId)
                .IsRequired(false);

            // LikedUsers
            builder.HasMany(m => m.LikedUsers)
                .WithMany();
        }
    }
}
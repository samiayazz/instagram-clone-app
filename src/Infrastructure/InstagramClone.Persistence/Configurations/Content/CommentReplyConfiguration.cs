using InstagramClone.Domain.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations.Content
{
    public class CommentReplyConfiguration : IEntityTypeConfiguration<CommentReply>
    {
        public void Configure(EntityTypeBuilder<CommentReply> builder)
        {
            // PK
            builder.HasKey(x => x.Id);

            // RepliedComment
            builder.HasOne(r => r.RepliedComment)
                .WithMany()
                .HasForeignKey(r => r.RepliedCommentId);

            // Recipient
            builder.HasOne(r => r.Recipient)
                .WithMany()
                .HasForeignKey(r => r.RecipientId);

            // Comment
            builder.HasOne(r => r.Comment)
                .WithMany()
                .HasForeignKey(r => r.CommentId);
        }
    }
}
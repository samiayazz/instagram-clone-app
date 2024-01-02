using InstagramClone.Domain.Entities.Chat;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations.Chat
{
    public class MessageReplyConfiguration : IEntityTypeConfiguration<MessageReply>
    {
        public void Configure(EntityTypeBuilder<MessageReply> builder)
        {
            // PK
            builder.HasKey(x => x.Id);

            // RepliedMessage
            builder.HasOne(r => r.RepliedMessage)
                .WithMany()
                .HasForeignKey(r => r.RepliedMessageId);

            // Message
            builder.HasOne(r => r.Message)
                .WithMany()
                .HasForeignKey(r => r.MessageId);
        }
    }
}
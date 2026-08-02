using InstagramClone.Domain.Entities;
using InstagramClone.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations
{
    public class GroupConfiguration : ModifiableEntityConfiguration<Group>
    {
        public override void Configure(EntityTypeBuilder<Group> builder)
        {
            ConfigureRelationships(builder);

            // Name
            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            // About
            builder.Property(x => x.About)
                .HasMaxLength(500)
                .IsRequired();
        }

        private void ConfigureRelationships(EntityTypeBuilder<Group> builder)
        {
            // Participants
            builder.HasMany(g => g.Participants)
                .WithMany();

            // Messages
            builder.HasMany(g => g.Messages)
                .WithOne(m => m.Group)
                .HasForeignKey(m => m.GroupId)
                .IsRequired(false);
        }
    }
}
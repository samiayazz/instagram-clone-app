using InstagramClone.Domain.Entities;
using InstagramClone.Persistence.Configurations.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations
{
    public class ThoughtConfiguration : ModifiableEntityConfiguration<Thought>
    {
        public override void Configure(EntityTypeBuilder<Thought> builder)
        {
            // Text
            builder.Property(x => x.Text)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
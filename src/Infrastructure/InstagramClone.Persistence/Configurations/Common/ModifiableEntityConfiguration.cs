using InstagramClone.Domain.Entities.Common.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations.Common
{
    public class ModifiableEntityConfiguration<T> : IEntityTypeConfiguration<T>
        where T : ModifiableEntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            // PK
            builder.HasKey(x => x.Id);

            // Created
            builder.HasOne(x => x.CreatedBy)
                .WithMany()
                .HasForeignKey(x => x.CreatedById);
            builder.Property(x => x.CreatedDate)
                .HasDefaultValue(DateTime.UtcNow)
                .IsRequired();

            // Updated
            builder.HasOne(x => x.UpdatedBy)
                .WithMany()
                .HasForeignKey(x => x.UpdatedById);
            builder.Property(x => x.UpdatedDate)
                .IsRequired(false);

            // Removed
            builder.HasOne(x => x.RemovedBy)
                .WithMany()
                .HasForeignKey(x => x.RemovedById);
            builder.Property(x => x.RemovedDate)
                .IsRequired(false);
        }
    }
}
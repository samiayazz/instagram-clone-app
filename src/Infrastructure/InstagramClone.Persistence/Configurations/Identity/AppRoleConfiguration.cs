using InstagramClone.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations.Identity
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // PK
            builder.HasKey(x => x.Id);

            // Name
            builder.Property(x => x.Name)
                .HasMaxLength(25)
                .IsRequired();
        }
    }
}
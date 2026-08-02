using InstagramClone.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InstagramClone.Persistence.Configurations.Identity
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // PK
            builder.HasKey(x => x.Id);

            // UserName
            builder.Property(x => x.UserName)
                .HasMaxLength(50)
                .IsRequired();

            // Email
            builder.Property(x => x.Email)
                .HasMaxLength(254)
                .IsRequired();

            // EmailConfirmed
            builder.Property(x => x.EmailConfirmed)
                .HasDefaultValue(0)
                .IsRequired();

            // PasswordHash
            builder.Property(x => x.PasswordHash)
                .IsRequired();

            // PhoneNumber
            builder.Property(x => x.PhoneNumber)
                .HasMaxLength(15)
                .IsRequired();

            // PhoneNumberConfirmed
            builder.Property(x => x.PhoneNumberConfirmed)
                .HasDefaultValue(0)
                .IsRequired();

            // Name
            builder.Property(x => x.FirstName)
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(x => x.LastName)
                .HasMaxLength(25)
                .IsRequired();

            // Gender
            builder.Property(x => x.Gender)
                .IsRequired();

            // BirthDate
            builder.Property(x => x.BirthDate)
                .IsRequired();

            // About
            builder.Property(x => x.About)
                .HasMaxLength(500)
                .IsRequired(false);

            // Date
            builder.Property(x => x.CreatedDate)
                .HasDefaultValue(DateTime.UtcNow)
                .IsRequired();
            builder.Property(x => x.UpdatedDate)
                .IsRequired(false);
            builder.Property(x => x.RemovedDate)
                .IsRequired(false);
            // IsRemoved
            builder.Property(x => x.IsRemoved)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}
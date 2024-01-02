using System.Reflection;
using InstagramClone.Domain.Entities;
using InstagramClone.Domain.Entities.Chat;
using InstagramClone.Domain.Entities.Common.Base;
using InstagramClone.Domain.Entities.Content;
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Persistence.Utils.AspNetCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Persistence.Contexts
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        private readonly HttpContextUtils _httpContextUtils;

        public AppDbContext(DbContextOptions<AppDbContext> options, HttpContextUtils httpContextUtils) : base(options)
            => _httpContextUtils = httpContextUtils;

        public DbSet<Group> Groups { get; private init; } = default!;
        public DbSet<Thought> Thoughts { get; private init; } = default!;

        public DbSet<Post> Posts { get; private init; } = default!;
        public DbSet<Comment> Comments { get; private init; } = default!;
        public DbSet<CommentReply> CommentReplies { get; private init; } = default!;

        public DbSet<Message> Messages { get; private init; } = default!;
        public DbSet<MessageReply> MessageReplies { get; private init; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();

            SetModifiedBysAndDates(_httpContextUtils.GetCurrentUserId());

            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
            CancellationToken cancellationToken = new CancellationToken())
        {
            ChangeTracker.DetectChanges();

            SetModifiedBysAndDates(_httpContextUtils.GetCurrentUserId());

            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void SetModifiedBysAndDates(Guid userId)
        {
            // Extended Classes from ModifiableEntityBase
            foreach (var entry in
                     ChangeTracker.Entries<ModifiableEntityBase>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property(x => x.CreatedById).CurrentValue = userId;
                    entry.Property(x => x.CreatedDate).CurrentValue = DateTime.UtcNow;
                }
                else if (entry.State == EntityState.Modified)
                {
                    if (entry.Property(x => x.IsRemoved).CurrentValue)
                    {
                        entry.Property(x => x.RemovedById).CurrentValue = userId;
                        entry.Property(x => x.RemovedDate).CurrentValue = DateTime.UtcNow;
                    }

                    entry.Property(x => x.UpdatedById).CurrentValue = userId;
                    entry.Property(x => x.UpdatedDate).CurrentValue = DateTime.UtcNow;
                }
            }

            // AppUser
            foreach (var entry in
                     ChangeTracker.Entries<AppUser>())
            {
                if (entry.State == EntityState.Added)
                    entry.Property(x => x.CreatedDate).CurrentValue = DateTime.UtcNow;
                else if (entry.State == EntityState.Modified)
                {
                    if (entry.Property(x => x.IsRemoved).CurrentValue)
                        entry.Property(x => x.RemovedDate).CurrentValue = DateTime.UtcNow;

                    entry.Property(x => x.UpdatedDate).CurrentValue = DateTime.UtcNow;
                }
            }
        }
    }
}
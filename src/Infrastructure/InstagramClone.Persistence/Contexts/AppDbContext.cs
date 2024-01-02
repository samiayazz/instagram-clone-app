using System.Reflection;
using InstagramClone.Domain.Entities;
using InstagramClone.Domain.Entities.Chat;
using InstagramClone.Domain.Entities.Content;
using InstagramClone.Domain.Entities.Identity;
using InstagramClone.Persistence.Configurations;
using InstagramClone.Persistence.Configurations.Chat;
using InstagramClone.Persistence.Configurations.Content;
using InstagramClone.Persistence.Configurations.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace InstagramClone.Persistence.Contexts
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

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

            /*builder.ApplyConfiguration(new AppUserConfiguration())
                .ApplyConfiguration(new AppRoleConfiguration())
                .ApplyConfiguration(new GroupConfiguration())
                .ApplyConfiguration(new ThoughtConfiguration());

            builder.ApplyConfiguration(new PostConfiguration())
                .ApplyConfiguration(new CommentConfiguration())
                .ApplyConfiguration(new CommentReplyConfiguration());

            builder.ApplyConfiguration(new MessageConfiguration())
                .ApplyConfiguration(new MessageReplyConfiguration());*/

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
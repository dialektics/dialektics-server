using Dialektiks.Models;
using Microsoft.EntityFrameworkCore;

namespace Dialektiks.Infrastructure
{
    public class Context : DbContext
    {
        public Context()
        { }

        public Context(DbContextOptions options) : base(options)
        { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Guild> Guilds => Set<Guild>();
        public DbSet<Channel> Channels => Set<Channel>();
        public DbSet<Message> Messages => Set<Message>();
        public DbSet<Relationship> Relationships => Set<Relationship>();
        public DbSet<GuildMember> GuildMembers => Set<GuildMember>();
        public DbSet<Attachment> Attachments => Set<Attachment>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //fehlt ???
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { }
    }
}

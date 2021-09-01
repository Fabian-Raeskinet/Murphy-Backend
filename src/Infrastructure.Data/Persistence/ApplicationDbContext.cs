using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<CategoryChannel> CategoryChannels { get; set; }
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<GuildMember> GuildMembers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TextChannel> TextChannels { get; set; }
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TextChannel>().HasOne(t => t.CategoryChannel)
                    .WithMany(c => c.TextChannels)
                    .HasForeignKey(t => t.CategoryChannelId)
                    .IsRequired(false);
        }
    }
}
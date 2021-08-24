using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<Guild> Guilds { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GuildMember> GuildMembers { get; set; }
    }
}
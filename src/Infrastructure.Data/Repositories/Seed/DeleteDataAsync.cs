using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.Seed
{
    public partial class SeedReposioty
    {
        public async Task<bool> ResetDataAsync()
        {
            try
            {
                await _context.Database.ExecuteSqlRawAsync("DELETE FROM dbo.GuildMembers");
                await _context.Database.ExecuteSqlRawAsync("DELETE FROM dbo.TextChannels");
                await _context.Database.ExecuteSqlRawAsync("DELETE FROM dbo.CategoryChannels");
                await _context.Database.ExecuteSqlRawAsync("DELETE FROM dbo.Roles");
                await _context.Database.ExecuteSqlRawAsync("DELETE FROM dbo.Users");
                await _context.Database.ExecuteSqlRawAsync("DELETE FROM dbo.Guilds");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
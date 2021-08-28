using System;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Guild
{
    public partial class GuildRepository
    {
        public async Task<Domain.Models.Guild> CreateGuildAsync(Domain.Models.Guild guild)
        {
            try
            {
                var addedGuild = await _context.Guilds.AddAsync(guild);
                await _context.SaveChangesAsync();
                return addedGuild.Entity;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
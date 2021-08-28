using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.Guild
{
    public partial class GuildRepository
    {
        public async Task<IEnumerable<Domain.Models.Guild>> GetGuildsAsync()
        {
            try
            {
                var guilds = await _context.Guilds.ToListAsync();
                return guilds;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.TextChannel
{
    public partial class TextChannelRepository
    {
        public async Task<IEnumerable<Domain.Models.TextChannel>> GetTextChannelsAsync()
        {
            try
            {
                var textChannels = await _context.TextChannels.ToListAsync();
                return textChannels;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
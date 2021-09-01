using System;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.TextChannel
{
    public partial class TextChannelRepository
    {
        public async Task<Domain.Models.TextChannel> CreateTextChannelAsync(Domain.Models.TextChannel textChannel)
        {
            try
            {
                var addedTextChannel = await _context.TextChannels.AddAsync(textChannel);
                await _context.SaveChangesAsync();
                return addedTextChannel.Entity;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
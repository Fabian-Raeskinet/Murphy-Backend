using System;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.CategoryChannel
{
    public partial class CategoryChannelRepository
    {
        public async Task<Domain.Models.CategoryChannel> CreateCategoryChannelAsync(Domain.Models.CategoryChannel channel)
        {
            try
            {
                var addedCategoryChannel = await _context.CategoryChannels.AddAsync(channel);
                await _context.SaveChangesAsync();
                return addedCategoryChannel.Entity;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
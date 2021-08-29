using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.CategoryChannel
{
    public partial class CategoryChannelRepository
    {
        public async Task<IEnumerable<Domain.Models.CategoryChannel>> GetCategoryChannelsAsync()
        {
            try
            {
                var categoryChannels = await _context.CategoryChannels.ToListAsync();
                return categoryChannels;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
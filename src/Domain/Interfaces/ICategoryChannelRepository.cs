using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICategoryChannelRepository
    {
        Task<IEnumerable<CategoryChannel>> GetCategoryChannelsAsync();
        Task<CategoryChannel> CreateCategoryChannelAsync(CategoryChannel channel);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface ITextChannelRepository
    {
        Task<IEnumerable<TextChannel>> GetTextChannelsAsync();
        Task<TextChannel> CreateTextChannelAsync(TextChannel textChannel);
    }
}
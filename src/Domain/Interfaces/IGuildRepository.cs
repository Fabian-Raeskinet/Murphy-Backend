using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IGuildRepository
    {
        Task<IEnumerable<Guild>> GetGuildsAsync();
        Task<Guild> CreateGuildAsync(Guild guild);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IGuildMemberRepository
    {
        Task<IEnumerable<GuildMember>> GetGuildMembersAsync();
        Task<GuildMember> CreateGuildMemberAsync(GuildMember guildMember);
    }
}
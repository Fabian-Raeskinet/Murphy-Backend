using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.GuildMember
{
    public partial class GuildMemberRepository
    {
        public async Task<IEnumerable<Domain.Models.GuildMember>> GetGuildMembersAsync()
        {
            try
            {
                var guildMembers = await _context.GuildMembers.ToListAsync();
                return guildMembers;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
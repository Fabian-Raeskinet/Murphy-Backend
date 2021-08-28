using System;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.GuildMember
{
    public partial class GuildMemberRepository
    {
        public async Task<Domain.Models.GuildMember> CreateGuildMemberAsync(Domain.Models.GuildMember guildMember)
        {
            try
            {
                var addedGuildMember = await _context.GuildMembers.AddAsync(guildMember);
                await _context.SaveChangesAsync();
                return addedGuildMember.Entity;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
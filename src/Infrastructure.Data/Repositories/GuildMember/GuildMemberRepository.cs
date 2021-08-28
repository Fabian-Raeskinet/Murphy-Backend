using Domain.Interfaces;
using Infrastructure.Data.Persistence;

namespace Infrastructure.Data.Repositories.GuildMember
{
    public partial class GuildMemberRepository : IGuildMemberRepository
    {
        private readonly ApplicationDbContext _context;
        public GuildMemberRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
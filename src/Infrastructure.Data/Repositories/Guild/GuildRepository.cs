using Domain.Interfaces;
using Infrastructure.Data.Persistence;

namespace Infrastructure.Data.Repositories.Guild
{
    public partial class GuildRepository : IGuildRepository
    {
        private readonly ApplicationDbContext _context;
        public GuildRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
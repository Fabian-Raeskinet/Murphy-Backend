using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data.Persistence;

namespace Infrastructure.Data.Repositories.TextChannel
{
    public partial class TextChannelRepository : ITextChannelRepository
    {
        private readonly ApplicationDbContext _context;

        public TextChannelRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       

        
    }
}
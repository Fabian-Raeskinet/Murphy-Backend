using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data.Persistence;

namespace Infrastructure.Data.Repositories.CategoryChannel
{
    public partial class CategoryChannelRepository : ICategoryChannelRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryChannelRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
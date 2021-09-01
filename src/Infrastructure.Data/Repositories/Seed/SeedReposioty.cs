using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data.Persistence;

namespace Infrastructure.Data.Repositories.Seed
{
    public partial class SeedReposioty : ISeedRepository
    {
        private readonly ApplicationDbContext _context;

        public SeedReposioty(ApplicationDbContext context)
        {
            _context = context;
        }

       
    }
}
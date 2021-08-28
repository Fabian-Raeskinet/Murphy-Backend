using System;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.User
{
    public partial class UserRepository
    {
        public async Task<Domain.Models.User> CreateUserAsync(Domain.Models.User user)
        {
            try
            {
                var addedUser = await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return addedUser.Entity;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
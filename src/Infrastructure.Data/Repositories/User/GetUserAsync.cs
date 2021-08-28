using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.User
{
    public partial class UserRepository
    {
        public async Task<IEnumerable<Domain.Models.User>> GetUsersAsync()
        {
            try
            {
                var users = await _context.Users.ToListAsync();
                return users;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
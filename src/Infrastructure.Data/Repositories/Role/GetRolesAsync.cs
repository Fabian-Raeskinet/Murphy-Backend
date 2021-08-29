using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories.Role
{
    public partial class RoleRepository
    {
        public async Task<IEnumerable<Domain.Models.Role>> GetRolesAsync()
        {
            try
            {
                var roles = await _context.Roles.ToListAsync();
                return roles;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
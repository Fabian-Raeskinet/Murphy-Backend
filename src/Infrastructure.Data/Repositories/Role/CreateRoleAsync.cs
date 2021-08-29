using System;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Role
{
    public partial class RoleRepository
    { 
        public async Task<Domain.Models.Role> CreateRoleAsync(Domain.Models.Role role)
        {
            try
            {
                var addedRole = await _context.Roles.AddAsync(role);
                await _context.SaveChangesAsync();
                return addedRole.Entity;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
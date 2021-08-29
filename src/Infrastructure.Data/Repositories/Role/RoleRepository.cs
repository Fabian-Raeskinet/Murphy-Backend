using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Infrastructure.Data.Persistence;

namespace Infrastructure.Data.Repositories.Role
{
    public partial class RoleRepository : IRoleRepository
    { 
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<User>> GetUsersAsync()
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

        public async Task<User> CreateUserAsync(User user)
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
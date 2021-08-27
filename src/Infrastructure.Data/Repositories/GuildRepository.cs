using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class GuildRepository : IGuildRepository
    {
        private readonly ApplicationDbContext _context;

        public GuildRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IEnumerable<Guild>> GetGuildsAsync()
        {
            try
            {
               var guilds = await _context.Guilds.ToListAsync();
               return guilds;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<bool> CreateGuildAsync(Guild guild)
        {
            try
            {
                await _context.Guilds.AddAsync(guild);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
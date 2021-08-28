using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Models;
using Infrastructure.Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class GuildMemberRepository : IGuildMemberRepository
    {
        private readonly ApplicationDbContext _context;

        public GuildMemberRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GuildMember>> GetGuildMembersAsync()
        {
            try
            {
                var guildMembers = await _context.GuildMembers.ToListAsync();
                return guildMembers;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<GuildMember> CreateUserAsync(GuildMember guildMember)
        {
            try
            {
                var addedGuildMember = await _context.GuildMembers.AddAsync(guildMember);
                await _context.SaveChangesAsync();
                return addedGuildMember.Entity;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Persistence
{
    public class MigrationManager
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;
        
        public MigrationManager(ApplicationDbContext context, ILogger logger) : base()
        {
            _context = context;
            _logger = logger;

            if (!_context.Database.IsSqlServer())
            {
                _logger.LogCritical("The database must be an SQL Server.");
            }
        }
        
        public async Task MigrateAsync()
        {
            try
            {
                await _context.Database.MigrateAsync().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while migrating the database.");
                throw;
            }
        }
    }
}
using Domain.Interfaces;
using Infrastructure.Data.Persistence;
using Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Basic Config
            
            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(config => { config.RootPath = "ClientApp/build"; });

            #endregion

            #region Database Config
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            #endregion

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                        {Title = "Murphy API v1", Version = "v1", Description = "Different APIs of Murphy"});
            });
            #endregion

            #region Repositories

            services.AddScoped(typeof(IGuildRepository), typeof(GuildRepository));
            services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
            services.AddScoped(typeof(IGuildMemberRepository), typeof(GuildMemberRepository));

            #endregion
            
            return services;
        }
    }
}
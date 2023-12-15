using CodeCollabra.Domain;
using CodeCollabra.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using CodeCollabra.Application.Repositories;
using CodeCollabra.Infrastructure.Repositories;

namespace CodeCollabra.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CodeCollabraDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DatabaseConnectionString"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAchievementsRepository, AchievementsRepository>();
            services.AddScoped<IPointsRepository, PointsRepository>();

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequiredLength = 8;
                options.SignIn.RequireConfirmedAccount = true;
            })
           .AddEntityFrameworkStores<CodeCollabraDBContext>()
           .AddDefaultTokenProviders();
            return services;
        }
    }
}

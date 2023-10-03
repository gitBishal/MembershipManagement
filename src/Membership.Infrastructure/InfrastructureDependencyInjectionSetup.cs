using Membership.Core.Interfaces;
using Membership.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Membership.Infrastructure
{
    public static class InfrastructureDependencyInjectionSetup
    {
        public static IServiceCollection AddServicesWithInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IMembershipRepository, MembershipRepository>();
            return services;
        }
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }

    }
}

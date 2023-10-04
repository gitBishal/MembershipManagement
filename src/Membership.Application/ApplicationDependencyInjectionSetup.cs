using Membership.Application.Interfaces;
using Membership.Application.Services;
using Membership.Core.Interfaces;
using Membership.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Membership.Application
{
    public  static class ApplicationDependencyInjectionSetup
    {
        public static IServiceCollection AddServicesWithApplication(this IServiceCollection services)
        {
            services.AddScoped<IMembershipService, MembershipService>();
            return services;
        }
    }
}
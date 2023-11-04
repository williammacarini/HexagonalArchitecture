using Application.Services;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationDependency
    {
        public static IServiceCollection AddApplicationDependency(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();
            return services;
        }
    }
}

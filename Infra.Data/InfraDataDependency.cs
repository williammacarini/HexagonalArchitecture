using Domain.Adapters;
using Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Data
{
    public static class InfraDataDependency
    {
        public static IServiceCollection AddInfraDataDependency(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();
            return services;
        }
    }
}

using Domain.Adapters;
using Infra.Email.Operations;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Email
{
    public static class InfraEmailDependency
    {
        public static IServiceCollection AddInfraEmailDependency(this IServiceCollection services)
        {
            services.AddScoped<IEmailAdapter, EmailOperation>();
            return services;
        }
    }
}

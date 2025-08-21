using Microsoft.Extensions.DependencyInjection;
using Together.Application.Common.Interfaces;
using Together.Infrastructure.Presistence;

namespace Together.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IEventRepository, EventMemReopository>();
        return services;
    }
}
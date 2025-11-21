using Backy.Application.Features.System.Auth;
using Backy.Application.Features.System.Ping;
using Microsoft.Extensions.DependencyInjection;

namespace Backy.Application.DependencyInjection;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // System
        services.AddScoped<PingHandler>();
        services.AddScoped<RegisterHandler>();
        services.AddScoped<LoginHandler>();

        // Project

        return services;
    }
}

using Microsoft.Extensions.DependencyInjection;
using Backy.Application.Features.System.Ping;

namespace Backy.Application.DependencyInjection.System;

public static class SystemDependencyInjection
{
    public static IServiceCollection AddSystemFeatures(this IServiceCollection services)
    {
        services.AddScoped<PingHandler>();

        return services;
    }
}

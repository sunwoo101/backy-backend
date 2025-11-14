using Backy.Application.DependencyInjection.Project;
using Backy.Application.DependencyInjection.System;
using Microsoft.Extensions.DependencyInjection;

namespace Backy.Application.DependencyInjection;

public static class ApplicationDependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddSystemFeatures();
        services.AddProjectFeatures();

        return services;
    }
}

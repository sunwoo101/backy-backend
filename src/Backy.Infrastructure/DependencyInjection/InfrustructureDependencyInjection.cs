using Backy.Application.Services.Repositories.System;
using Backy.Application.Services.Security;
using Backy.Infrastructure.Persistence;
using Backy.Infrastructure.Persistence.System;
using Backy.Infrastructure.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Backy.Infrastructure.DependencyInjection;

public static class InfrastructureDependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<BackyDbContext>(options => options.UseSqlite("Data Source=backy-dev.sqlite"));

        // Repositories
        services.AddScoped<IDeveloperRepository, DeveloperRepository>();

        // Security
        services.AddScoped<IPasswordHasher, PasswordHasher>();

        return services;
    }
}

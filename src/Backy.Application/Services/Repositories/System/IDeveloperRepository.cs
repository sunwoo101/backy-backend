using Backy.Domain.Entities.System;

namespace Backy.Application.Services.Repositories.System;

public interface IDeveloperRepository
{
    Task<bool> ExistsAsync(string normalizedEmail);
    Task AddAsync(Developer developer);
    Task<Developer?> GetByEmailAsync(string normalizedEmail);
}

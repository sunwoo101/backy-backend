using Backy.Domain.Entities.System;

namespace Backy.Application.Services.Repositories.System;

public interface IDeveloperRepository
{
    Task<bool> EmailExistsAsync(string normalizedEmail);
    Task<bool> UsernameExistsAsync(string normalizedUsername);
    Task AddAsync(Developer developer);
    Task<Developer?> GetByEmailAsync(string normalizedEmail);
    Task<Developer?> GetByEmailOrUsernameAsync(string normalizedIdentifier);
}

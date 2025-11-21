using Backy.Application.Services.Repositories.System;
using Backy.Domain.Entities.System;
using Microsoft.EntityFrameworkCore;

namespace Backy.Infrastructure.Persistence.System;

public sealed class DeveloperRepository(BackyDbContext db) : IDeveloperRepository
{
    public async Task<bool> ExistsAsync(string normalizedEmail)
    {
        return await db.Developers.AnyAsync(d => d.Email == normalizedEmail);
    }

    public async Task AddAsync(Developer developer)
    {
        db.Developers.Add(developer);
        await db.SaveChangesAsync();
    }

    public async Task<Developer?> GetByEmailAsync(string normalizedEmail)
    {
        return await db.Developers.FirstOrDefaultAsync(d => d.Email == normalizedEmail);
    }
}

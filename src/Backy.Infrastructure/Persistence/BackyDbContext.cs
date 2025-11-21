using Backy.Domain.Entities.System;
using Backy.Domain.Entities.Project;
using Microsoft.EntityFrameworkCore;
using Backy.Domain.Common.System;

namespace Backy.Infrastructure.Persistence;

public sealed class BackyDbContext(DbContextOptions<BackyDbContext> options) : DbContext(options)
{
    // System Entities
    public DbSet<Developer> Developers => Set<Developer>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Collaborator> Collaborators => Set<Collaborator>();

    // Project Entities
    public DbSet<ProjectUser> ProjectUsers => Set<ProjectUser>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entries = ChangeTracker.Entries<BaseEntity>();

        foreach (var entry in entries)
        {
            if (entry.State == EntityState.Added)
            {
                entry.Entity.CreatedAt = DateTime.UtcNow;
                entry.Entity.UpdatedAt = DateTime.UtcNow;
            }

            if (entry.State == EntityState.Modified)
            {
                entry.Entity.UpdatedAt = DateTime.UtcNow;
            }
        }

        return await base.SaveChangesAsync(cancellationToken);
    }
}

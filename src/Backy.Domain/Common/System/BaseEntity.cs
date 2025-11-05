namespace Backy.Domain.Common.System;

/// <summary>
/// The base type for all entities in the system.
/// Provides a unique identifier and common audit fields.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Globally unique identifier for this entity.
    /// Generated automatically when the entity is created.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// The UTC timestamp when the entity was first created.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// The UTC timestamp when the entity was last modified.
    /// Null if it has never been updated.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}

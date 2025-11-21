using Backy.Domain.Common.System;

namespace Backy.Domain.Common.Project;

/// <summary>
/// The base type for all entities that belong to a specific project.
/// Inherits standard audit fields and enforces a required ProjectId.
/// </summary>
public abstract class BaseProjectEntity : BaseEntity
{
    /// <summary>
    /// The unique identifier of the project that owns this entity.
    /// Must be explicitly provided when creating the object.
    /// </summary>
    public required Guid PublicProjectId { get; set; }
}

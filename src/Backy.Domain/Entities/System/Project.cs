using Backy.Domain.Common.System;

namespace Backy.Domain.Entities.System;

/// <summary>
/// Represents a project created by a developer.
/// Each project has a globally unique GUID that can be safely exposed in frontend applications.
/// </summary>
public class Project : BaseEntity
{
    /// <summary>
    /// The display name of the project.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The developer who owns this project.
    /// </summary>
    public required Guid OwnerId { get; set; }

    /// <summary>
    /// The globally unique identifier for this project.
    /// Safe to expose publicly in frontend code.
    /// </summary>
    public Guid PublicProjectId { get; private set; } = Guid.NewGuid();

    /// <summary>
    /// Developers who have access to this project (including the owner).
    /// </summary>
    public ICollection<Collaborator> Collaborators { get; set; } = [];
}

using Backy.Domain.Enums.System;

namespace Backy.Domain.Entities.System;

/// <summary>
/// Represents a developer who has access to a project.
/// The owner can invite collaborators with specific roles and permissions.
/// </summary>
public class Collaborator
{
    /// <summary>
    /// The unique identifier of the project this collaborator belongs to.
    /// </summary>
    public required Guid ProjectId { get; set; }

    /// <summary>
    /// The unique identifier of the developer who is collaborating on the project.
    /// </summary>
    public required Guid DeveloperId { get; set; }

    /// <summary>
    /// The collaborator's role within the project (e.g., Owner, Editor, Viewer).
    /// </summary>
    public CollaboratorRole Role { get; set; } = CollaboratorRole.Editor;

    /// <summary>
    /// Navigation reference to the project.
    /// </summary>
    public Project? Project { get; set; }

    /// <summary>
    /// Navigation reference to the developer.
    /// </summary>
    public Developer? Developer { get; set; }
}

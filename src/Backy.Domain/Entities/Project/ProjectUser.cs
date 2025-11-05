using Backy.Domain.Common.Project;

namespace Backy.Domain.Entities.Project;

/// <summary>
/// Represents an end-user within a developer's project.
/// These users register directly with Backy and are required to have an email and password.
/// </summary>
public class ProjectUser : BaseProjectEntity
{
    /// <summary>
    /// The user's unique email address for authentication.
    /// </summary>
    public required string Email { get; set; }

    /// <summary>
    /// The hashed password for authentication.
    /// </summary>
    public required string PasswordHash { get; set; }

    /// <summary>
    /// Optional display name or username for this user within the project.
    /// </summary>
    public string? DisplayName { get; set; }
}

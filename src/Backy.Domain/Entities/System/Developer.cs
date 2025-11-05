using Backy.Domain.Common.System;

namespace Backy.Domain.Entities.System;

/// <summary>
/// Represents a developer registered in Backy.
/// A developer can own multiple projects.
/// </summary>
public class Developer : BaseEntity
{
    /// <summary>
    /// The developer’s display name.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// The developer’s unique email address for authentication and contact.
    /// </summary>
    public required string Email { get; set; }

    /// <summary>
    /// The hashed password used for authentication.
    /// </summary>
    public required string PasswordHash { get; set; }

    /// <summary>
    /// The collection of projects owned by this developer.
    /// </summary>
    public ICollection<Project>? Projects { get; set; }
}

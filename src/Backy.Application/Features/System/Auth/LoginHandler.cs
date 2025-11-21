using Backy.Domain.Entities.System;
using Backy.Application.Services.Repositories.System;
using Backy.Application.Services.Security;
using System.Text.RegularExpressions;

namespace Backy.Application.Features.System.Auth;

public sealed class LoginHandler(
    IDeveloperRepository developerRepository,
    IPasswordHasher passwordHasher)
{
    public async Task<string> Handle(LoginRequest request)
    {
        if (request.Identifier == null)
            return "Email/Username is missing";

        if (request.Password == null)
            return "Password is missing";

        var identifier = request.Identifier.Trim().ToLowerInvariant();

        var registeredDeveloper = await developerRepository.GetByEmailOrUsernameAsync(identifier);

        if (registeredDeveloper == null)
            return "Incorrect username/password";

        var passwordVerified = passwordHasher.Verify(request.Password, registeredDeveloper.PasswordHash);
        if (!passwordVerified)
            return "Incorrect username/password";

        return "Successfully Logged In";
    }
}

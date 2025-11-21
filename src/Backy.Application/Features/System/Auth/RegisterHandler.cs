using Backy.Domain.Entities.System;
using Backy.Application.Services.Repositories.System;
using Backy.Application.Services.Security;
using System.Text.RegularExpressions;

namespace Backy.Application.Features.System.Auth;

public sealed class RegisterHandler(
    IDeveloperRepository developerRepository,
    IPasswordHasher passwordHasher)
{
    public async Task<string> Handle(RegisterRequest request)
    {
        if (request.Email == null)
            return "Email is missing";

        if (request.Username == null)
            return "Username is missing";

        if (request.Password == null)
            return "Password is missing";

        var email = request.Email.Trim().ToLowerInvariant();
        var username = request.Username.Trim();

        if (!IsValidEmail(request.Email))
            return "Email is invalid.";

        if (!IsValidUsername(request.Username))
            return "Username is invalid.";

        if (request.Password.Length < 8)
            return "Password must be at least 8 characters";

        if (!request.Password.Any(char.IsUpper))
            return "Password must contain a capital letter";

        if (!request.Password.Any(char.IsDigit))
            return "Password must contain a number";

        if (!request.Password.Any(c => !char.IsLetterOrDigit(c)))
            return "Password must contain a special character";

        if (await developerRepository.ExistsAsync(email))
            return "Email already registered";

        var hash = passwordHasher.Hash(request.Password);

        var developer = new Developer
        {
            Username = username,
            Email = email,
            PasswordHash = hash
        };

        await developerRepository.AddAsync(developer);

        return "Successfully Registered";
    }

    private static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[A-Za-z]{2,63}$";
        return Regex.IsMatch(email, pattern);
    }

    public static bool IsValidUsername(string username)
    {
        string pattern = @"^[a-zA-Z0-9._]+$";
        return Regex.IsMatch(username, pattern);
    }
}

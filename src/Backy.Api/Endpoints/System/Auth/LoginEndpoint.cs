using Backy.Application.Features.System.Auth;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Backy.Api.Endpoints.System.Auth;

public static class LoginEndpoint
{
    public static void MapLogin(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/system/auth/login", Handle)
            .WithName("System.Auth.Login")
            .WithSummary("Login Developer Account")
            .WithDescription("Logs in a Developer registered in System");
    }

    private static async Task<Ok<string>> Handle(
        LoginRequest request,
        LoginHandler handler)
    {
        var message = await handler.Handle(request);

        return TypedResults.Ok(message);
    }
}

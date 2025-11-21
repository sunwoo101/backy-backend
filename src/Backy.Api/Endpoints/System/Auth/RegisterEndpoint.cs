using Backy.Application.Features.System.Auth;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Backy.Api.Endpoints.System.Auth;

public static class RegisterEndpoint
{
    public static void MapRegister(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/system/auth/register", Handle)
            .WithName("System.Auth.Register")
            .WithSummary("Register Developer Account")
            .WithDescription("Registers a Developer account to the system");
    }

    private static async Task<Ok<string>> Handle(
        RegisterRequest request,
        RegisterHandler handler)
    {
        var message = await handler.Handle(request);

        return TypedResults.Ok(message);
    }
}

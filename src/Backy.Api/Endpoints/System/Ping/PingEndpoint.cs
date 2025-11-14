using Backy.Application.Features.System.Ping;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Backy.Api.Endpoints.System.Ping;

/// <summary>
/// The Ping endpoint serves as a minimal example showing how Backy endpoints
/// are structured. It demonstrates the typical pattern:
///
///     - Endpoint class (this file)
///     - Request DTO  (PingRequest)
///     - Response DTO (PingResponse)
///     - Application layer Handler
///
/// Not every endpoint will require all of these pieces, but Ping includes them
/// to show the expected folder layout for contributors.
/// </summary>
public static class PingEndpoint
{
    public static void MapPing(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/system/ping", Handle)
            .WithName("System.Ping")
            .WithSummary("System health check")
            .WithDescription("Demonstrates Backy’s endpoint structure and template.");
    }

    private static async Task<Ok<string>> Handle(
        [AsParameters] PingRequest _,                 // request DTO (unused for Ping)
        PingHandler handler)      // application layer use-case
    {
        var message = await handler.Handle(_);

        return TypedResults.Ok(message);
    }
}

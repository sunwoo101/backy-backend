namespace Backy.Application.Features.System.Ping;

/// <summary>
/// Example handler that shows how application-layer logic is separated from
/// the API layer. The Ping endpoint uses this handler only as part of the
/// template structure.
///
/// Real handlers will contain meaningful application logic. This one simply
/// returns a constant value.
/// </summary>
public sealed class PingHandler
{
    public async Task<string> Handle(PingRequest _)
    {
        return "pong";
    }
}

using Backy.Api.Endpoints.System.Ping;

namespace Backy.Api.Endpoints.Mappers;

public static class SystemEndpointMapper
{
    public static void MapSystemEndpoints(this WebApplication app)
    {
        app.MapPing();
    }
}

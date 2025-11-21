using Backy.Api.Endpoints.System.Ping;
using Backy.Api.Endpoints.System.Auth;

namespace Backy.Api.Endpoints.Mappers;

public static class SystemEndpointMapper
{
    public static void MapSystemEndpoints(this WebApplication app)
    {
        // Ping
        app.MapPing();

        // Auth
        app.MapRegister();
        app.MapLogin();
    }
}

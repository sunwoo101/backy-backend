namespace Backy.Api.Endpoints.Mappers;

public static class EndpointMapper
{
    public static void MapAllEndpoints(this WebApplication app)
    {
        app.MapSystemEndpoints();
        app.MapProjectEndpoints();
    }
}

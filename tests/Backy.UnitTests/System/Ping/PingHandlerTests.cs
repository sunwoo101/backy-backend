using Backy.Application.Features.System.Ping;

namespace Backy.UnitTests.System.Ping;

public class PingHandlerTests
{
    [Fact]
    public async Task Handle_ShouldReturnPing()
    {
        // Arrange
        var handler = new PingHandler();
        var request = new PingRequest();

        // Act
        var response = await handler.Handle(request);

        // Assert
        Assert.Equal("pong", response);
    }
}

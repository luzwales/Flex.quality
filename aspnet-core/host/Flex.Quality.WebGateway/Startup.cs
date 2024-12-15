using Flex.Quality.WebGateway;

namespace Flex.Quality.WebGateway;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<WebGatewayModule>();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.InitializeApplication();
    }
}
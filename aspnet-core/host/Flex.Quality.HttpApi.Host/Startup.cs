namespace Flex.Quality;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<QualityHttpApiHostModule>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
namespace Flex.Quality;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<QualityHttpApiHostModule>();
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins",
                              builder =>
                              {
                                  builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader();
                              });
        });
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
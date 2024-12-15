using Volo.Abp.Data;

namespace Flex.Quality.DbMigrator;

public class DbMigratorHostedService : IHostedService
{
    private readonly IConfiguration _configuration;
    private readonly IHostApplicationLifetime _hostApplicationLifetime;

    public DbMigratorHostedService(IHostApplicationLifetime hostApplicationLifetime,
        IConfiguration configuration)
    {
        _hostApplicationLifetime = hostApplicationLifetime;
        _configuration = configuration;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        using (var application = await AbpApplicationFactory.CreateAsync<QualityDbMigratorModule>(options =>
               {
                   options.Services.ReplaceConfiguration(_configuration);
                   options.UseAutofac();
                   options.Services.AddLogging(c => c.AddSerilog());
                   // https://github.com/abpframework/abp/pull/15208
                   options.AddDataMigrationEnvironment();
               }))
        {
            await application.InitializeAsync();

            await application
                .ServiceProvider
                .GetRequiredService<QualityDbMigrationService>()
                .MigrateAsync();

            await application.ShutdownAsync();

            _hostApplicationLifetime.StopApplication();
        }
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
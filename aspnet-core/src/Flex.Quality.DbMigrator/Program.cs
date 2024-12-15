namespace Flex.Quality.DbMigrator;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Volo.Abp", LogEventLevel.Warning)
#if DEBUG
            .MinimumLevel.Override("Flex.Quality", LogEventLevel.Debug)
#else
                .MinimumLevel.Override("Flex.Quality", LogEventLevel.Information)
#endif
            .Enrich.FromLogContext()
            .WriteTo.Async(c => c.File("Logs/logs.txt"))
            .WriteTo.Async(c => c.Console())
            .CreateLogger();

        await CreateHostBuilder(args).RunConsoleAsync();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureLogging((context, logging) => logging.ClearProviders())
            .ConfigureAppConfiguration
            (
                otpions =>
                {
                    var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

                    var appSettingFileName = "appsettings.json";
                    if (!environment.IsNullOrWhiteSpace())
                        appSettingFileName = $"appsettings.{environment}.json";

                    otpions.AddJsonFile(appSettingFileName, true);
                }
            )
            .ConfigureServices((hostContext, services) => { services.AddHostedService<DbMigratorHostedService>(); });
    }
}
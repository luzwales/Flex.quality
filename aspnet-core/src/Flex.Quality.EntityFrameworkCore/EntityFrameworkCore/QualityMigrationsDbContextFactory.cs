namespace Flex.Quality.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class QualityMigrationsDbContextFactory : IDesignTimeDbContextFactory<QualityDbContext>
{
    public QualityDbContext CreateDbContext(string[] args)
    {
        QualityEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<QualityDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new QualityDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath
            (
                Path.Combine
                (
                    Directory.GetCurrentDirectory(),
                    "../Flex.Quality.DbMigrator/"
                )
            )
            .AddJsonFile
            (
                "appsettings.json",
                false
            );

        return builder.Build();
    }
}
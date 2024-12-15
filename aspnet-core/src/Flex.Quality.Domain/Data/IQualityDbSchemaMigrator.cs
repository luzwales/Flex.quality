namespace Flex.Quality.Data;

public interface IQualityDbSchemaMigrator
{
    Task MigrateAsync();
}
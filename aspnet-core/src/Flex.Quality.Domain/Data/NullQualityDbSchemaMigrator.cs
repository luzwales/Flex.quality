namespace Flex.Quality.Data;

/* This is used if database provider does't define
 * IQualityDbSchemaMigrator implementation.
 */
public class NullQualityDbSchemaMigrator : IQualityDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
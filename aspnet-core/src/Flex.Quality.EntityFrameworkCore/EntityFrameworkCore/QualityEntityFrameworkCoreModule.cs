using Volo.Abp.Guids;

namespace Flex.Quality.EntityFrameworkCore;

[DependsOn(
    typeof(QualityDomainModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule),
    typeof(BasicManagementEntityFrameworkCoreModule),
    typeof(DataDictionaryManagementEntityFrameworkCoreModule),
    typeof(NotificationManagementEntityFrameworkCoreModule),
    typeof(LanguageManagementEntityFrameworkCoreModule)
)]
public class QualityEntityFrameworkCoreModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        QualityEfCoreEntityExtensionMappings.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<QualityDbContext>(options =>
        {
            /* Remove "includeAllEntities: true" to create
             * default repositories only for aggregate roots */
            options.AddDefaultRepositories(true);
        });
        Configure<AbpSequentialGuidGeneratorOptions>(options =>
        {
            options.DefaultSequentialGuidType = SequentialGuidType.SequentialAsString;
        });
        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also QualityMigrationsDbContextFactory for EF Core tooling. */
            options.UseSqlServer();
        });
    }
}
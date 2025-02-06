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
    // 在服务配置之前执行
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        // 配置EF Core实体扩展映射
        QualityEfCoreEntityExtensionMappings.Configure();
    }

    // 在服务配置中执行
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // 添加ABP DbContext
        context.Services.AddAbpDbContext<QualityDbContext>(options =>
        {
            /* Remove "includeAllEntities: true" to create
             * default repositories only for aggregate roots */
            options.AddDefaultRepositories(true);
        });
        // 配置ABP顺序GUID生成器选项
        Configure<AbpSequentialGuidGeneratorOptions>(options =>
        {
            options.DefaultSequentialGuidType =
                SequentialGuidType.SequentialAsString;
        });
        // 配置ABP DbContext选项
        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also QualityMigrationsDbContextFactory for EF Core tooling. */
            options.UseSqlServer();
        });
    }
}
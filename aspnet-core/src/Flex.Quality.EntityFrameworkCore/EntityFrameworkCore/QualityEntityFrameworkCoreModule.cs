using Lion.AbpPro.CodeManagement;
using Lion.AbpPro.CodeManagement.EntityFrameworkCore;
using Lion.AbpPro.LanguageManagement;
using Volo.Abp.BlobStoring.Database;
using Volo.Abp.Guids;
using Volo.Abp.OpenIddict;

namespace Flex.Quality.EntityFrameworkCore;

[DependsOn(
    typeof(QualityDomainModule),
    typeof(AbpEntityFrameworkCoreSqlServerModule),
    typeof(BasicManagementEntityFrameworkCoreModule),
    typeof(DataDictionaryManagementEntityFrameworkCoreModule),
    typeof(NotificationManagementEntityFrameworkCoreModule),
    typeof(LanguageManagementEntityFrameworkCoreModule),
    typeof(CodeManagementEntityFrameworkCoreModule),
    typeof(AbpPermissionManagementDomainModule)
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
        AbpIdentityDbProperties.DbSchema = "Qa";
        AbpIdentityDbProperties.DbTablePrefix = "Abp_";
        AbpPermissionManagementDbProperties.DbSchema = "Qa";
        AbpPermissionManagementDbProperties.DbTablePrefix = "Abp_";
        AbpTenantManagementDbProperties.DbSchema = "Qa";
        AbpTenantManagementDbProperties.DbTablePrefix = "Abp_";
        AbpBackgroundJobsDbProperties.DbTablePrefix = "Abp_";
        AbpBackgroundJobsDbProperties.DbSchema = "Qa";
        AbpOpenIddictDbProperties.DbTablePrefix = "Abp_";
        AbpOpenIddictDbProperties.DbSchema = "Qa";
        AbpSettingManagementDbProperties.DbTablePrefix = "Abp_";
        AbpSettingManagementDbProperties.DbSchema = "Qa";
        AbpBlobStoringDatabaseDbProperties.DbTablePrefix = "Abp_";
        AbpBlobStoringDatabaseDbProperties.DbSchema = "Qa";
        AbpFeatureManagementDbProperties.DbTablePrefix = "Abp_";
        AbpFeatureManagementDbProperties.DbSchema = "Qa";
        AbpAuditLoggingDbProperties.DbTablePrefix = "Abp_";
        AbpAuditLoggingDbProperties.DbSchema = "Qa";
        DataDictionaryManagementDbProperties.DbTablePrefix = "Abp_";
        DataDictionaryManagementDbProperties.DbSchema = "Qa";
        LanguageManagementDbProperties.DbTablePrefix = "QA.Abp_";
        // LanguageManagementDbProperties.DbSchema = "Qa";
        NotificationManagementDbProperties.DbTablePrefix = "Abp_";
        NotificationManagementDbProperties.DbSchema = "Qa";
        CodeManagementDbProperties.DbTablePrefix = "Qa.Abp_";
    }
}
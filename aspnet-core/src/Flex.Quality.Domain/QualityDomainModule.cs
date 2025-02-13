using Lion.AbpPro.CodeManagement;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.BlobStoring.Database;
using Volo.Abp.FeatureManagement;
using Volo.Abp.OpenIddict;
using Volo.Abp.PermissionManagement;

namespace Flex.Quality;

[DependsOn(
    typeof(QualityDomainSharedModule),
    typeof(BasicManagementDomainModule),
    typeof(NotificationManagementDomainModule),
    typeof(DataDictionaryManagementDomainModule),
    typeof(LanguageManagementDomainModule),
    typeof(CodeManagementDomainModule)
)]
public class QualityDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpMultiTenancyOptions>(options => { options.IsEnabled = MultiTenancyConsts.IsEnabled; });
        Configure<AbpAutoMapperOptions>(options => { options.AddMaps<QualityDomainModule>(); });
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
namespace Flex.Quality;

[DependsOn(
    typeof(QualityDomainSharedModule),
    typeof(BasicManagementDomainModule),
    typeof(NotificationManagementDomainModule),
    typeof(DataDictionaryManagementDomainModule),
    typeof(LanguageManagementDomainModule)
)]
public class QualityDomainModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpMultiTenancyOptions>(options => { options.IsEnabled = MultiTenancyConsts.IsEnabled; });
        Configure<AbpAutoMapperOptions>(options => { options.AddMaps<QualityDomainModule>(); });
    }
}
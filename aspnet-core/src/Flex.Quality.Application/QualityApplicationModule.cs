namespace Flex.Quality;

[DependsOn(
    typeof(QualityDomainModule),
    typeof(QualityApplicationContractsModule),
    typeof(BasicManagementApplicationModule),
    typeof(NotificationManagementApplicationModule),
    typeof(DataDictionaryManagementApplicationModule),
    typeof(LanguageManagementApplicationModule),
    typeof(QualityFreeSqlModule)
)]
public class QualityApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options => { options.AddMaps<QualityApplicationModule>(); });
    }
}
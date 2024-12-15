namespace Flex.Quality;

[DependsOn(
    typeof(QualityDomainSharedModule),
    typeof(AbpObjectExtendingModule),
    typeof(BasicManagementApplicationContractsModule),
    typeof(NotificationManagementApplicationContractsModule),
    typeof(DataDictionaryManagementApplicationContractsModule),
    typeof(LanguageManagementApplicationContractsModule)
)]
public class QualityApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        QualityDtoExtensions.Configure();
    }
}
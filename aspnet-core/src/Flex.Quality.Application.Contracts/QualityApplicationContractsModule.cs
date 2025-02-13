using Lion.AbpPro.CodeManagement;

namespace Flex.Quality;

[DependsOn(
    typeof(QualityDomainSharedModule),
    typeof(AbpObjectExtendingModule),
    typeof(BasicManagementApplicationContractsModule),
    typeof(NotificationManagementApplicationContractsModule),
    typeof(DataDictionaryManagementApplicationContractsModule),
    typeof(LanguageManagementApplicationContractsModule),
    typeof(CodeManagementApplicationContractsModule)
)]
public class QualityApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        QualityDtoExtensions.Configure();
    }
}
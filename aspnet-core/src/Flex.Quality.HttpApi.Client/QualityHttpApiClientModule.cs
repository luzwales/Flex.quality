using Lion.AbpPro.BasicManagement;
using Lion.AbpPro.CodeManagement;
using Lion.AbpPro.DataDictionaryManagement;
using Lion.AbpPro.LanguageManagement;
using Lion.AbpPro.NotificationManagement;

namespace Flex.Quality;

[DependsOn(
    typeof(QualityApplicationContractsModule),
    typeof(BasicManagementHttpApiClientModule),
    typeof(NotificationManagementHttpApiClientModule),
    typeof(DataDictionaryManagementHttpApiClientModule),
    typeof(LanguageManagementHttpApiClientModule),
    typeof(CodeManagementHttpApiClientModule)
)]
public class QualityHttpApiClientModule : AbpModule
{
    public const string RemoteServiceName = "Default";

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(QualityApplicationContractsModule).Assembly
        );
    }
}
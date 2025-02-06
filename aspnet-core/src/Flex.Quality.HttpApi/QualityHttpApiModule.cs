using Lion.AbpPro.DataDictionaryManagement;
using Lion.AbpPro.LanguageManagement;

namespace Flex.Quality;

[DependsOn(
    typeof(QualityApplicationContractsModule),
    typeof(BasicManagementHttpApiModule),
    typeof(NotificationManagementHttpApiModule),
    typeof(DataDictionaryManagementHttpApiModule),
    typeof(LanguageManagementHttpApiModule)
)]
public class QualityHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<OrganizationResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
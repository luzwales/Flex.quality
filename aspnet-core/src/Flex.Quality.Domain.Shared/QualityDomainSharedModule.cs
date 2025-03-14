using Lion.AbpPro.CodeManagement;

namespace Flex.Quality;

[DependsOn(
    typeof(BasicManagementDomainSharedModule),
    typeof(NotificationManagementDomainSharedModule),
    typeof(DataDictionaryManagementDomainSharedModule),
    typeof(LanguageManagementDomainSharedModule),
    typeof(AbpProCoreModule),
    typeof(CodeManagementDomainSharedModule)
)]
public class QualityDomainSharedModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        QualityGlobalFeatureConfigurator.Configure();
        QualityModuleExtensionConfigurator.Configure();
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<QualityDomainSharedModule>(
                QualityDomainSharedConsts.NameSpace);
        });

        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Add<OrganizationResource>(QualityDomainSharedConsts.DefaultCultureName)
                .AddVirtualJson("/Localization/Quality")
                .AddBaseTypes(typeof(BasicManagementResource))
                .AddBaseTypes(typeof(AbpTimingResource));

            options.DefaultResourceType = typeof(OrganizationResource);
        });

        Configure<AbpExceptionLocalizationOptions>(options =>
        {
            options.MapCodeNamespace(
                QualityDomainSharedConsts.NameSpace,
                typeof(OrganizationResource));
        });
    }
}
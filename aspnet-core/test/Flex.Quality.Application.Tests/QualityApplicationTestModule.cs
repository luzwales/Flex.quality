using Volo.Abp.Modularity;

namespace Flex.Quality;

[DependsOn(
    typeof(QualityApplicationModule),
    typeof(QualityDomainTestModule)
)]
public class QualityApplicationTestModule : AbpModule
{
}
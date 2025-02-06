namespace Flex.Quality;

/* Inherit your application services from this class.
 */
public abstract class QualityAppService : ApplicationService
{
    protected QualityAppService()
    {
        LocalizationResource = typeof(OrganizationResource);
    }
}
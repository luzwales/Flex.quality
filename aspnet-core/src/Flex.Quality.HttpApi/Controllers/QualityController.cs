namespace Flex.Quality.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class QualityController : AbpController
{
    protected QualityController()
    {
        LocalizationResource = typeof(QualityResource);
    }
}
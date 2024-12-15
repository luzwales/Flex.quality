namespace Flex.Quality.Controllers;

public class HomeController : AbpController
{
    public ActionResult Index()
    {
        return Redirect("/Login");
    }
}
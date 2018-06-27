using Betcoins.Web.Filters;
using System.Web.Mvc;

namespace Betcoins.Web.Controllers
{
    [ControllerAuthorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Init()
        {
            return View();
        }

        public ActionResult Index()
        {
            return PartialView();
        }
    }
}

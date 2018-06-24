using System.Web.Mvc;

namespace Betcoins.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
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

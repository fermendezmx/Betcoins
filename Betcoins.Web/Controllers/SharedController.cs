using System.Web.Mvc;

namespace Betcoins.Web.Controllers
{
    public class SharedController : Controller
    {
        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}

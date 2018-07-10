using System.Web.Mvc;

namespace Betcoins.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public ActionResult Detail()
        {
            return PartialView();
        }
    }
}

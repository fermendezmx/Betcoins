using Betcoins.Web.Filters;
using System.Web.Mvc;

namespace Betcoins.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        [ValidateAntiXsrf]
        public ActionResult Detail()
        {
            return PartialView();
        }
    }
}

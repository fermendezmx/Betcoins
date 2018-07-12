using System.Linq;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Betcoins.Web.Filters
{
    public sealed class ApiAntiForgery : ActionFilterAttribute
    {
        private const string HeaderId = "AntiXsrfToken";

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string clientToken = actionContext.Request.Headers.GetValues(HeaderId).FirstOrDefault();
            string serverToken = actionContext.Request.Headers.GetCookies().Select(x => x[AntiForgeryConfig.CookieName]).FirstOrDefault()?.Value;
            AntiForgery.Validate(serverToken, clientToken);
            base.OnActionExecuting(actionContext);
        }
    }
}
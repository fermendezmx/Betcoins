using System.Web.Helpers;
using System.Web.Mvc;

namespace Betcoins.Web.Filters
{
    public class MvcAntiForgery : FilterAttribute, IAuthorizationFilter
    {
        private const string HeaderId = "AntiXsrfToken";

        public void OnAuthorization(AuthorizationContext filterContext)
        {
            string clientToken = filterContext.RequestContext.HttpContext.Request.Headers.Get(HeaderId);
            string serverToken = filterContext.HttpContext.Request.Cookies.Get(AntiForgeryConfig.CookieName).Value;
            AntiForgery.Validate(serverToken, clientToken);
        }
    }
}
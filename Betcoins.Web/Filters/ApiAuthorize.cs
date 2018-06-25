using System.Web.Http;
using System.Web.Http.Controllers;

namespace Betcoins.Web.Filters
{
    public class ApiAuthorize : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext httpActionContext)
        {
            base.OnAuthorization(httpActionContext);
        }
    }
}
using System.Web.Mvc;

namespace Betcoins.Web.Filters
{
    public class ControllerAuthorize : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext authorizationContext)
        {
            base.OnAuthorization(authorizationContext);
        }
    }
}
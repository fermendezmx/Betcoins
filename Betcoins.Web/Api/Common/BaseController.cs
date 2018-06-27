using System.Linq;
using System.Security.Claims;
using System.Web.Http;

namespace Betcoins.Web.Api.Common
{
    public class BaseController : ApiController
    {
        private const string Auth0Id = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier";

        public string AccountId
        {
            get
            {
                return (User.Identity as ClaimsIdentity).Claims.FirstOrDefault(claim => claim.Type == Auth0Id)?.Value;
            }
        }
    }
}

using Betcoins.BusinessLogic.Contracts;
using Betcoins.Model.Client;
using Betcoins.Web.Api.Common;
using System.Web.Http;

namespace Betcoins.Web.Api
{
    [Authorize]
    public class AccountController : BaseController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IHttpActionResult Get(string id)
        {
            return Ok(_accountService.Read(id));
        }

        public IHttpActionResult Post(_Account data)
        {
            return Ok(_accountService.Create(data));
        }
    }
}
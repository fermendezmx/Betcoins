using Betcoins.BusinessLogic.Contracts;
using Betcoins.Model.Client;
using Betcoins.Web.Api.Common;
using System.Web.Http;

namespace Betcoins.Web.Api
{
    public class AccountController : BaseController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IHttpActionResult Get(int id)
        {
            return Ok(_accountService.Get(id));
        }

        public IHttpActionResult Post(_Account account)
        {
            return Ok(account);
        }
    }
}
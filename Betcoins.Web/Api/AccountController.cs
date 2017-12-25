using Betcoins.BusinessLogic.Contracts;
using Betcoins.Model.Client;
using System.Web.Http;

namespace Betcoins.Web.Api
{
    public class AccountController : ApiController
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public Account Get(int id)
        {
            return _accountService.Get(id);
        }
    }
}
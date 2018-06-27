using Betcoins.BusinessLogic.Contracts;
using Betcoins.Model.Client;
using Betcoins.Web.Api.Common;

namespace Betcoins.Web.Api
{
    public class AccountController : BaseController
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
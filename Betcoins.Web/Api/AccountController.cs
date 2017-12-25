using Betcoins.BusinessLogic.Contracts;
using Betcoins.BusinessLogic.Implementations;
using Betcoins.DomainClasses.Models;
using System.Web.Http;

namespace Betcoins.Web.Api
{
    public class AccountController : ApiController
    {
        private readonly IAccountService _accountService;

        public AccountController()
        {
            _accountService = new AccountService();
        }

        public Account Get(int id)
        {
            return _accountService.Get(id);
        }
    }
}
using Betcoins.BusinessLogic.Contracts;
using Betcoins.DomainClasses.Models;
using Betcoins.Repositories.Contracts;
using Betcoins.Repositories.Implementations;

namespace Betcoins.BusinessLogic.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }

        public Account Get(int id)
        {
            return _accountRepository.GetById(id);
        }
    }
}

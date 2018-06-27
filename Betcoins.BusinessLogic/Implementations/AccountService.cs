using AutoMapper;
using Betcoins.BusinessLogic.Contracts;
using Betcoins.Model.Client;
using Betcoins.Repositories.Contracts;

namespace Betcoins.BusinessLogic.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public _Account Get(int id)
        {
            return Mapper.Map<_Account>(_accountRepository.GetById(id));
        }
    }
}

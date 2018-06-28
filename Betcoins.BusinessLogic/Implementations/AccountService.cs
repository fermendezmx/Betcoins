using AutoMapper;
using Betcoins.BusinessLogic.Contracts;
using Betcoins.DomainClasses.Models;
using Betcoins.Model.Client;
using Betcoins.Repositories.Contracts;
using System;

namespace Betcoins.BusinessLogic.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public _Account Read(string id)
        {
            return Mapper.Map<_Account>(_accountRepository.GetById(id));
        }

        public _Account Create(_Account data)
        {
            try
            {
                Account account = _accountRepository.GetById(data.AccountId);

                if (account == null)
                {
                    account = Mapper.Map<Account>(data);
                    account.CreatedDate = DateTime.Now;
                    account.ModifiedDate = DateTime.Now;

                    _accountRepository.Insert(account);
                    _accountRepository.Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return data;
        }
    }
}

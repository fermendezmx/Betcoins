using Betcoins.Context.Common;
using Betcoins.DomainClasses.Models;
using Betcoins.Repositories.Contracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Betcoins.Repositories.Implementations
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AccountContext _context;

        public AccountRepository()
        {
            _context = new AccountContext();
        }

        #region Base

        public Account GetById(int id)
        {
            return _context.Accounts.FirstOrDefault(x => x.AccountId == id);
        }

        public List<Account> GetAll()
        {
            return _context.Accounts.ToList();
        }

        public void Insert(Account data)
        {
            _context.Entry(data).State = EntityState.Added;
        }

        public void Update(Account data)
        {
            _context.Entry(data).State = EntityState.Modified;
        }

        public void Delete(Account data)
        {
            _context.Entry(data).State = EntityState.Deleted;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        #endregion
    }
}

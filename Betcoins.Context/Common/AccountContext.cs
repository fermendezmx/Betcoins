using Betcoins.Context.Base;
using Betcoins.DomainClasses.Models;
using Betcoins.DomainClasses.Models.Mapping;
using System.Data.Entity;

namespace Betcoins.Context.Common
{
    public class AccountContext : BaseContext<AccountContext>
    {
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
        }
    }
}

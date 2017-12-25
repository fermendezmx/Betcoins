using Betcoins.DomainClasses.Models;

namespace Betcoins.BusinessLogic.Contracts
{
    public interface IAccountService
    {
        Account Get(int id);
    }
}

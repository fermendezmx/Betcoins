using Betcoins.Model.Client;

namespace Betcoins.BusinessLogic.Contracts
{
    public interface IAccountService
    {
        Account Get(int id);
    }
}

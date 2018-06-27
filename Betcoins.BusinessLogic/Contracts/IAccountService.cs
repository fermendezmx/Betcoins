using Betcoins.Model.Client;

namespace Betcoins.BusinessLogic.Contracts
{
    public interface IAccountService
    {
        _Account Get(int id);
    }
}

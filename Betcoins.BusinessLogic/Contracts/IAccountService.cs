using Betcoins.Infrastructure.Shared;
using Betcoins.Model.Client;

namespace Betcoins.BusinessLogic.Contracts
{
    public interface IAccountService
    {
        _Account Read(string id);
        XHRResponse<_Account> Create(_Account data);
    }
}

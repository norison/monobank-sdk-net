using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    public interface IPersonalClient
    {
        Task<ClientInfo> GetClientInfoAsync(string token, CancellationToken cancellationToken = default);
    }
}
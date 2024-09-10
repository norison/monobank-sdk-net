using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    public class PersonalClient : IPersonalClient
    {
        public async Task<ClientInfo> GetClientInfoAsync(string token, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    public class PersonalClient : IPersonalClient
    {
        private readonly IRestClient _restClient;

        public PersonalClient(IRestClient restClient)
        {
            _restClient = restClient;
        }
        
        public async Task<ClientInfo> GetClientInfoAsync(string token, CancellationToken cancellationToken = default)
        {
            return await _restClient.GetAsync<ClientInfo>("personal/client-info", token, cancellationToken);
        }
    }
}
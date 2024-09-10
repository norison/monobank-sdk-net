using System;
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

        public async Task<ClientInfo> GetClientInfoAsync(string? token = null,
            CancellationToken cancellationToken = default)
        {
            return await _restClient.GetAsync<ClientInfo>("personal/client-info", token, cancellationToken);
        }

        public Task<Statement[]> GetStatementsAsync(string account, DateTime from, DateTime to, string? token = null,
            CancellationToken cancellationToken = default)
        {
            return _restClient.GetAsync<Statement[]>(
                $"personal/statement/{account}/{from.ToUnixTime()}/{to.ToUnixTime()}", token, cancellationToken);
        }
    }
}
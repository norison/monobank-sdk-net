using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    public class BankClient : IBankClient
    {
        private readonly IRestClient _restClient;

        public BankClient(IRestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<CurrencyInfo[]> GetCurrenciesAsync(CancellationToken cancellationToken = default)
        {
            return await _restClient.GetAsync<CurrencyInfo[]>("bank/currency", cancellationToken);
        }
    }
}
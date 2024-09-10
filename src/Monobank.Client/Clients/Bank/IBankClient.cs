using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    public interface IBankClient
    {
        Task<CurrencyInfo[]> GetCurrenciesAsync(CancellationToken cancellationToken = default);
    }
}
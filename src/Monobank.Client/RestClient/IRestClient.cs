using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    public interface IRestClient
    {
        Task<T> GetAsync<T>(string url, CancellationToken cancellationToken = default);
        Task PostAsync<T>(string url, T data, CancellationToken cancellationToken = default);
    }
}
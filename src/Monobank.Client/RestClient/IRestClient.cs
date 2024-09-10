using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    public interface IRestClient
    {
        Task<T> GetAsync<T>(string uri, string? token = null, CancellationToken cancellationToken = default);
        Task PostAsync<T>(string uri, object body, string? token = null, CancellationToken cancellationToken = default);
    }
}
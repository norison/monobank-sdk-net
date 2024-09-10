using System;
using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    public interface IPersonalClient
    {
        Task<ClientInfo> GetClientInfoAsync(string? token = null, CancellationToken cancellationToken = default);

        Task<Statement[]> GetStatementsAsync(string account, DateTime from, DateTime to, string? token = null,
            CancellationToken cancellationToken = default);

        Task SetWebHookAsync(string url, string? token = null, CancellationToken cancellationToken = default);
    }
}
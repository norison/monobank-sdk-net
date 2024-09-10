using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    [ExcludeFromCodeCoverage]
    public class RestClient : IRestClient
    {
        private readonly HttpClient _client;

        public RestClient(HttpClient client)
        {
            _client = client;
        }        
        
        public async Task<T> GetAsync<T>(string url, CancellationToken cancellationToken = default)
        {
            var uri = new Uri(url, UriKind.Relative);
            var response = await _client.GetAsync(uri, cancellationToken);
            var responseString = await response.Content.ReadAsStringAsync();
            
            if (response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<T>(responseString);
            }
            
            var error = JsonSerializer.Deserialize<Error>(responseString);
            throw new MonobankApiException(error.Description);
        }

        public async Task PostAsync<T>(string url, T data, CancellationToken cancellationToken = default)
        {
            var uri = new Uri(url, UriKind.Relative);
            var content = JsonSerializer.Serialize(data);
            var response = await _client.PostAsync(uri, new StringContent(content), cancellationToken);
            
            if (response.IsSuccessStatusCode)
            {
                return;
            }
            
            var responseString = await response.Content.ReadAsStringAsync();
            var error = JsonSerializer.Deserialize<Error>(responseString);
            throw new MonobankApiException(error.Description);
        }
    }
}
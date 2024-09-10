using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Monobank.Client
{
    [ExcludeFromCodeCoverage]
    public class RestClient : IRestClient
    {
        private readonly ClientOptions _options;
        private HttpClient _httpClient;

        public RestClient(ClientOptions options)
        {
            _options = options;
        }

        public async Task<T> GetAsync<T>(string uri, string token = null, CancellationToken cancellationToken = default)
        {
            var response = await SendAsync(uri, HttpMethod.Get, token, null, cancellationToken);

            var responseString = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString);
        }

        public async Task PostAsync<T>(string uri, object body, string token = null,
            CancellationToken cancellationToken = default)
        {
            await SendAsync(uri, HttpMethod.Post, token, body, cancellationToken);
        }

        private async Task<HttpResponseMessage> SendAsync(
            string uri,
            HttpMethod httpMethod,
            string token = null,
            object body = null,
            CancellationToken cancellationToken = default)
        {
            EnsureHttpClient();

            using var httpRequest = new HttpRequestMessage(httpMethod, uri);

            if (body is not null)
            {
                var content = JsonSerializer.Serialize(body);
                httpRequest.Content = new StringContent(content, Encoding.UTF8, "application/json");
            }

            if (token is not null || _options.Token is not null)
            {
                httpRequest.Headers.Add("X-Token", token ?? _options.Token);
            }

            var response = await _httpClient.SendAsync(httpRequest, cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                return response;
            }

            var responseString = await response.Content.ReadAsStringAsync();
            var error = JsonSerializer.Deserialize<Error>(responseString);
            throw new MonobankApiException(error.Description);
        }

        private void EnsureHttpClient()
        {
            if (_httpClient is not null)
            {
                return;
            }

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(_options.BaseUrl);
        }
    }
}
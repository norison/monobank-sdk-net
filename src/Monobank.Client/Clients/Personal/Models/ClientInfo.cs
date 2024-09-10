using System.Text.Json.Serialization;

namespace Monobank.Client
{
    public class ClientInfo
    {
        [JsonPropertyName("clientId")] public string ClientId { get; set; }
        [JsonPropertyName("name")] public string Name { get; set; }
        [JsonPropertyName("webHookUrl")] public string WebHookUrl { get; set; }
        [JsonPropertyName("accounts")] public Account[] Accounts { get; set; }
    }
}
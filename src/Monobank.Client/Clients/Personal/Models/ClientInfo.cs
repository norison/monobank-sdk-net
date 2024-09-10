using System;
using System.Text.Json.Serialization;

namespace Monobank.Client
{
    public class ClientInfo
    {
        [JsonPropertyName("clientId")] public string ClientId { get; set; } = string.Empty;
        [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
        [JsonPropertyName("webHookUrl")] public string WebHookUrl { get; set; } = string.Empty;
        [JsonPropertyName("accounts")] public Account[] Accounts { get; set; } = Array.Empty<Account>();
        [JsonPropertyName("jars")] public Jar[] Jars { get; set; } = Array.Empty<Jar>();
    }
}
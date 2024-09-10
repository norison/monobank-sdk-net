using System.Text.Json.Serialization;

namespace Monobank.Client
{
    public class Jar
    {
        [JsonPropertyName("id")] public string Id { get; set; } = string.Empty;
        [JsonPropertyName("sendId")] public string SendId { get; set; } = string.Empty;
        [JsonPropertyName("title")] public string Title { get; set; } = string.Empty;
        [JsonPropertyName("description")] public string Description { get; set; } = string.Empty;
        [JsonPropertyName("currencyCode")] public int CurrencyCode { get; set; }
        [JsonPropertyName("balance")] public long Balance { get; set; }
        [JsonPropertyName("goal")] public long? Goal { get; set; }
    }
}
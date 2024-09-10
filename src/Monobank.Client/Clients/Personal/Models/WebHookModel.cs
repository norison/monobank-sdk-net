using System.Text.Json.Serialization;

namespace Monobank.Client
{
    public class WebHookModel
    {
        [JsonPropertyName("type")] public string Type { get; set; } = string.Empty;
        [JsonPropertyName("data")] public WebHookData Data { get; set; } = new();
    }
}
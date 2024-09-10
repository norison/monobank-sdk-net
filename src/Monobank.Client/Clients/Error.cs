using System.Text.Json.Serialization;

namespace Monobank.Client
{
    public class Error
    {
        [JsonPropertyName("errorDescription")] public string Description { get; set; } = string.Empty;
    }
}
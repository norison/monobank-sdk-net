using System.Text.Json.Serialization;

namespace Monobank.Client
{
    public class WebHookData
    {
        [JsonPropertyName("account")] public string Account { get; set; } = string.Empty;
        [JsonPropertyName("statementItem")] public Statement StatementItem { get; set; } = new();
    }
}
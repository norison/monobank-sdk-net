using System.Text.Json.Serialization;

namespace Monobank.Client
{
    public sealed class CurrencyInfo
    {
        [JsonPropertyName("currencyCodeA")]
        public int CurrencyCodeA { get; set; }

        [JsonPropertyName("currencyCodeB")]
        public int CurrencyCodeB { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }

        [JsonPropertyName("rateSell")]
        public float RateSell { get; set; }

        [JsonPropertyName("rateBuy")]
        public float RateBuy { get; set; }

        [JsonPropertyName("rateCross")]
        public float RateCross { get; set; }
    }
}

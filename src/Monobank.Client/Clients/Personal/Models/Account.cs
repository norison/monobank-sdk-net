using System.Text.Json.Serialization;

namespace Monobank.Client
{
    public class Account
    {
        [JsonPropertyName("id")] public string Id { get; set; }
        [JsonPropertyName("balance")] public long Balance { get; set; }
        [JsonPropertyName("creditLimit")] public long CreditLimit { get; set; }
        [JsonPropertyName("currencyCode")] public int CurrencyCode { get; set; }
        [JsonPropertyName("cashbackType")] public CashbackType CashbackType { get; set; }
        [JsonPropertyName("type")] public AccountType Type { get; set; }
    }
}
using System;
using System.Text.Json.Serialization;

namespace Monobank.Client
{
    public class Statement
    {
        [JsonPropertyName("id")] public string Id { get; set; } = string.Empty;
        [JsonPropertyName("time")] public long TimeInSeconds { get; set; }
        [JsonPropertyName("description")] public string Description { get; set; } = string.Empty;
        [JsonPropertyName("mcc")] public int MerchantCategoryCode { get; set; }
        [JsonPropertyName("hold")] public bool IsHold { get; set; }
        [JsonPropertyName("amount")] public long Amount { get; set; }
        [JsonPropertyName("operationAmount")] public long OperationAmount { get; set; }
        [JsonPropertyName("currencyCode")] public int CurrencyCode { get; set; }
        [JsonPropertyName("commissionRate")] public long CommissionRate { get; set; }
        [JsonPropertyName("cashbackAmount")] public long CashbackAmount { get; set; }
        [JsonPropertyName("balance")] public long Balance { get; set; }
        [JsonPropertyName("comment")] public string? Comment { get; set; }
        [JsonPropertyName("receiptId")] public string? ReceiptId { get; set; }
        [JsonPropertyName("invoiceId")] public string? InvoiceId { get; set; }
        [JsonPropertyName("counterEdrpou")] public string? CounterEdrpou { get; set; }
        [JsonPropertyName("counterIban")] public string? CounterIban { get; set; }
        [JsonPropertyName("counterName")] public string? CounterName { get; set; }

        public DateTime Time => TimeInSeconds.ToDateTime();
    }
}
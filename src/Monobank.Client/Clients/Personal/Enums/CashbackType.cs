using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Monobank.Client
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CashbackType
    {
        [EnumMember(Value = "")] None = 0,
        [EnumMember(Value = "UAH")] Uah = 1,
        [EnumMember(Value = "Miles")] Miles = 2
    }
}
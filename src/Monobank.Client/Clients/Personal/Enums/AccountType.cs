using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Monobank.Client
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AccountType
    {
        [EnumMember(Value = "black")] Black,
        [EnumMember(Value = "white")] White,
        [EnumMember(Value = "platinum")] Platinum,
        [EnumMember(Value = "iron")] Iron,
        [EnumMember(Value = "fop")] Fop,
        [EnumMember(Value = "yellow")] Yellow,
        [EnumMember(Value = "eAid")] EAid
    }
}
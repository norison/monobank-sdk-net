namespace Monobank.Client
{
    public class ClientOptions
    {
        public string BaseUrl { get; set; } = "https://api.monobank.ua";
        public string? Token { get; set; }
    }
}
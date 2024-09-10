namespace Monobank.Client
{
    public static class MonobankClientFactory
    {
        public static IMonobankClient Create(ClientOptions options)
        {
            var restClient = new RestClient(options);
            var bankClient = new BankClient(restClient);
            var personalClient = new PersonalClient(restClient);
            return new MonobankClient(bankClient, personalClient);
        }
    }
}
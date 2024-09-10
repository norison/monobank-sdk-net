namespace Monobank.Client
{
    public static class MonobankClientFactory
    {
        public static IMonobankClient Create(ClientOptions? options = null)
        {
            var restClient = new RestClient(options ?? new ClientOptions());
            var bankClient = new BankClient(restClient);
            var personalClient = new PersonalClient(restClient);
            return new MonobankClient(bankClient, personalClient);
        }
    }
}
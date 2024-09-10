namespace Monobank.Client
{
    public class MonobankClient : IMonobankClient
    {
        public MonobankClient(IBankClient bankClient, IPersonalClient personalClient)
        {
            Bank = bankClient;
            Personal = personalClient;
        }

        public IBankClient Bank { get; }
        public IPersonalClient Personal { get; }
    }
}
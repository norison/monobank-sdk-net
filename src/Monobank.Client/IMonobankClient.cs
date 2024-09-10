namespace Monobank.Client
{
    public interface IMonobankClient
    {
        IBankClient Bank { get; }
        IPersonalClient Personal { get; }
    }
}
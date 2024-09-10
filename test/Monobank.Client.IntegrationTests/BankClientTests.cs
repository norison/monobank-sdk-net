using FluentAssertions;

namespace Monobank.Client.IntegrationTests;

public class BankClientTests
{
    private readonly IMonobankClient _client = MonobankClientFactory.Create();

    [Fact]
    public async Task GetCurrencyRatesAsync_WhenCalled_ThenReturnsCurrencyRates()
    {
        // Act
        var result = await _client.Bank.GetCurrenciesAsync();

        // Assert
        result.Should().NotBeEmpty();
    }
}
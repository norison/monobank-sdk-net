using AutoFixture;

using FluentAssertions;

using NSubstitute;

namespace Monobank.Client.UnitTests.Clients;

public class BankClientTests
{
    private readonly Fixture _fixture;
    private readonly IRestClient _restClient;
    private readonly BankClient _sut;

    public BankClientTests()
    {
        _fixture = new Fixture();
        _restClient = Substitute.For<IRestClient>();
        _sut = new BankClient(_restClient);
    }

    [Fact]
    public async Task GetCurrenciesAsync_WhenCalled_ThenReturnsCurrencies()
    {
        // Arrange
        var currencies = _fixture.CreateMany<CurrencyInfo>().ToArray();
        _restClient.GetAsync<CurrencyInfo[]>("bank/currency").Returns(currencies);

        // Act
        var result = await _sut.GetCurrenciesAsync();

        // Assert
        result.Should().BeEquivalentTo(currencies);
    }
}
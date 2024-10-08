using FluentAssertions;

namespace Monobank.Client.IntegrationTests;

public class PersonalClientTests
{
    private const string Token = ""; // Your token here
    private const string Account = ""; // Your account here
    private readonly IMonobankClient _client = MonobankClientFactory.Create(new ClientOptions { Token = Token });

    [Fact]
    public async Task GetClientInfoAsync_WhenInvalidToken_ThenReturnsError()
    {
        // Act & Assert
        await _client
            .Invoking(async x => await x.Personal.GetClientInfoAsync("invalid_token"))
            .Should()
            .ThrowAsync<MonobankApiException>()
            .WithMessage("Unknown 'X-Token'");
    }

    [Fact]
    public async Task GetClientInfoAsync_WhenValidToken_ThenReturnsClientInfo()
    {
        // Act
        var result = await _client.Personal.GetClientInfoAsync();

        // Assert
        result.Should().NotBeNull();
    }
    
    [Fact]
    public async Task GetStatementsAsync_WhenCalled_ThenReturnsStatements()
    {
        // Arrange
        var to = DateTime.Now;
        var from = to.AddDays(-7);

        // Act
        var result = await _client.Personal.GetStatementsAsync(Account, from, to);

        // Assert
        result.Should().NotBeEmpty();
    }
}
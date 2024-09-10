using AutoFixture;

using FluentAssertions;

using NSubstitute;

namespace Monobank.Client.UnitTests.Clients;

public class PersonalClientTests
{
    private readonly Fixture _fixture;
    private readonly IRestClient _restClient;
    private readonly PersonalClient _sut;

    public PersonalClientTests()
    {
        _fixture = new Fixture();
        _restClient = Substitute.For<IRestClient>();
        _sut = new PersonalClient(_restClient);
    }

    [Fact]
    public async Task GetClientInfoAsync_WhenCalled_ThenReturnsClientInfo()
    {
        // Arrange
        var token = _fixture.Create<string>();
        var clientInfo = _fixture.Create<ClientInfo>();
        _restClient.GetAsync<ClientInfo>("personal/client-info", token).Returns(clientInfo);

        // Act
        var result = await _sut.GetClientInfoAsync(token);

        // Assert
        result.Should().BeEquivalentTo(clientInfo);
        await _restClient.Received(1).GetAsync<ClientInfo>("personal/client-info", token);
    }
}
using FluentAssertions;

using Monobank.Client.Extensions;

namespace Monobank.Client.UnitTests.Extensions
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void ToUnixTime_WhenEpoch_ThenReturnsZero()
        {
            // Arrange
            var epoch = new DateTime(1970, 1, 1);

            // Act
            var result = epoch.ToUnixTime();

            // Assert
            result.Should().Be(0);
        }

        [Fact]
        public void ToUnixTime_WhenDateAfterEpoch_ThenReturnsCorrectUnixTime()
        {
            // Arrange
            var date = new DateTime(1970, 1, 2);

            // Act
            var result = date.ToUnixTime();

            // Assert
            result.Should().Be(86400); // 1 day in seconds
        }

        [Fact]
        public void ToUnixTime_WhenDateBeforeEpoch_ThenReturnsNegativeUnixTime()
        {
            // Arrange
            var date = new DateTime(1969, 12, 31);

            // Act
            var result = date.ToUnixTime();

            // Assert
            result.Should().Be(-86400); // 1 day before epoch in seconds
        }
    }
}
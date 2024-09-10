using FluentAssertions;

using Monobank.Client.Extensions;

namespace Monobank.Client.UnitTests.Extensions
{
    public class Int64ExtensionsTests
    {
        [Fact]
        public void ToDateTime_WhenZeroSeconds_ThenReturnsEpoch()
        {
            // Arrange
            const long seconds = 0;

            // Act
            var result = seconds.ToDateTime();

            // Assert
            result.Should().Be(new DateTime(1970, 1, 1));
        }

        [Fact]
        public void ToDateTime_WhenPositiveSeconds_ThenReturnsCorrectDateTime()
        {
            // Arrange
            const long seconds = 86400; // 1 day in seconds

            // Act
            var result = seconds.ToDateTime();

            // Assert
            result.Should().Be(new DateTime(1970, 1, 2));
        }

        [Fact]
        public void ToDateTime_WhenNegativeSeconds_ThenReturnsCorrectDateTime()
        {
            // Arrange
            const long seconds = -86400; // 1 day before epoch in seconds

            // Act
            var result = seconds.ToDateTime();

            // Assert
            result.Should().Be(new DateTime(1969, 12, 31));
        }
    }
}
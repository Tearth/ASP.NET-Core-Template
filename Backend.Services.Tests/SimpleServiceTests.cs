using System;
using System.Threading.Tasks;
using Backend.Services.SimpleThing;
using Xunit;

namespace Backend.Services.Tests
{
    public class SimpleServiceTests
    {
        [Fact]
        public async Task GetValue_NoParameters_ShouldReturnValue()
        {
            // Arrange
            var simpleService = new SimpleService();

            // Act
            var result = await simpleService.GetValue();

            // Assert
            Assert.Equal("value", result);
        }
        [Fact]
        public async Task GetValues_NoParameters_ShouldReturnValues()
        {
            // Arrange
            var simpleService = new SimpleService();

            // Act
            var result = await simpleService.GetValues();

            // Assert
            Assert.Equal(result, new [] { "value1", "value2" });
        }
    }
}

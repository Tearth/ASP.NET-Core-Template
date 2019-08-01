using System.Threading.Tasks;
using Backend.API.Controllers;
using Xunit;

namespace Backend.API.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public async Task Get_NoParameters_ShouldReturnValue()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = await controller.Get(1);

            // Assert
            Assert.Equal("value", result.Value);
        }
    }
}

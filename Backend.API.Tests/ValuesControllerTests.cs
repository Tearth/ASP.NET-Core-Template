using System.Threading.Tasks;
using Backend.API.Controllers;
using Backend.Services.Dtos;
using Backend.Services.SimpleThing;
using Moq;
using Xunit;

namespace Backend.API.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public async Task Get_NoParameters_ShouldReturnValue()
        {
            // Arrange
            var simpleService = new Mock<ISimpleService>();
            simpleService.Setup(p => p.GetValue()).Returns(
                Task.FromResult(new TestDto {Name = "value"}));

            var controller = new ValuesController(simpleService.Object);

            // Act
            var result = await controller.Get(1);

            // Assert
            Assert.Equal("value", result.Value.Name);
        }
    }
}

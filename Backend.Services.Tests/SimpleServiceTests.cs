using System.Linq;
using System.Threading.Tasks;
using Backend.DataAccess.Models;
using Backend.Services.SimpleThing;
using Backend.Services.Tests.Helpers;
using Xunit;

namespace Backend.Services.Tests
{
    public class SimpleServiceTests
    {
        [Fact]
        public async Task GetValue_NoParameters_ShouldReturnValue()
        {
            // Arrange
            var database = DatabaseFactory.CreateContext();
            var mapper = MapperFactory.Create();
            var simpleService = new SimpleService(database, mapper);

            database.TestModels.Add(new TestModel { Id = 1, Name = "value" });
            database.SaveChanges();

            // Act
            var result = await simpleService.GetValue();

            // Assert
            Assert.Equal("value", result.Name);
        }
        [Fact]
        public async Task GetValues_NoParameters_ShouldReturnValues()
        {
            // Arrange
            var database = DatabaseFactory.CreateContext();
            var mapper = MapperFactory.Create();
            var simpleService = new SimpleService(database, mapper);

            database.TestModels.Add(new TestModel { Id = 1, Name = "value1" });
            database.TestModels.Add(new TestModel { Id = 2, Name = "value2" });
            database.SaveChanges();

            // Act
            var result = await simpleService.GetValues();

            // Assert
            Assert.Equal(result.Select(p => p.Name), new [] { "value1", "value2" });
        }
    }
}

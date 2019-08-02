using System;
using System.Threading.Tasks;
using Backend.DataAccess.Context;
using Backend.DataAccess.Models;
using Backend.Services.SimpleThing;
using Backend.Services.Tests.Helpers;
using Microsoft.EntityFrameworkCore;
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
            var simpleService = new SimpleService(database);

            database.TestModels.Add(new TestModel { Id = 1, Name = "value" });
            database.SaveChanges();

            // Act
            var result = await simpleService.GetValue();

            // Assert
            Assert.Equal("value", result);
        }
        [Fact]
        public async Task GetValues_NoParameters_ShouldReturnValues()
        {
            // Arrange
            var database = DatabaseFactory.CreateContext();
            var simpleService = new SimpleService(database);

            database.TestModels.Add(new TestModel { Id = 1, Name = "value1" });
            database.TestModels.Add(new TestModel { Id = 2, Name = "value2" });
            database.SaveChanges();

            // Act
            var result = await simpleService.GetValues();

            // Assert
            Assert.Equal(result, new [] { "value1", "value2" });
        }
    }
}

using System;
using Backend.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services.Tests.Helpers
{
    public static class DatabaseFactory
    {
        public static DatabaseContext CreateContext()
        {
            return  new DatabaseContext(
                new DbContextOptionsBuilder<DatabaseContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options);
        }
    }
}

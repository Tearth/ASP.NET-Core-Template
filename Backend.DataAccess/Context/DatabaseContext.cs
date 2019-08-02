using Backend.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Backend.DataAccess.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }

        public DatabaseContext(IConfiguration configuration) : base(GetDbContextOptions(configuration))
        {
            
        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        private static DbContextOptions<DatabaseContext> GetDbContextOptions(IConfiguration configuration)
        {
            return new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlite(configuration.GetConnectionString("MainDatabase"))
                .Options;
        }
    }
}

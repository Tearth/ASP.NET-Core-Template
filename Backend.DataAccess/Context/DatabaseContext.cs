using Backend.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Backend.DataAccess.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}

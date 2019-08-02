using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess.Context
{
    public class DatabaseContextConfiguration
    {
        public static void Configure(DbContextOptionsBuilder<DatabaseContext> builder, string connectionString)
        {
            builder.UseSqlite(connectionString);
        }
    }
}

using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.EntityFrameworkCore
{
    public static class ToDoAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ToDoAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ToDoAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

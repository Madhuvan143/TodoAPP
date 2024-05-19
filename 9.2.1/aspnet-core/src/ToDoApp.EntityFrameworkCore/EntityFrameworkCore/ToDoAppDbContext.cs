using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ToDoApp.Authorization.Roles;
using ToDoApp.Authorization.Users;
using ToDoApp.MultiTenancy;

namespace ToDoApp.EntityFrameworkCore
{
    public class ToDoAppDbContext : AbpZeroDbContext<Tenant, Role, User, ToDoAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ToDoAppDbContext(DbContextOptions<ToDoAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration here if needed
        }
    }
}

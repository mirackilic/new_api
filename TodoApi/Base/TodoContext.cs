using Microsoft.EntityFrameworkCore;
using TodoApi.Entity;

namespace TodoApi.Base
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
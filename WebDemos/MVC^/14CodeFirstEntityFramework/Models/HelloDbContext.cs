using Microsoft.EntityFrameworkCore;

namespace _14CodeFirstEntityFramework.Models
{
    public class HelloDbContext : DbContext
    {

        public DbSet<Employee> employees { get; set; }

        public HelloDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}

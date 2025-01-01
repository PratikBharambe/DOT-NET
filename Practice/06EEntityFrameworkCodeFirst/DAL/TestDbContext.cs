using _06EEntityFrameworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace _06EEntityFrameworkCodeFirst.DAL
{
    public class TestDbContext : DbContext
    {

        public DbSet<Movies>? Movies { get; set; }

        public TestDbContext(DbContextOptions options) : base(options) { }

    }
}

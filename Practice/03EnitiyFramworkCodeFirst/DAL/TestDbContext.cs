
using _03EnitiyFramworkCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _03EnitiyFramworkCodeFirst.DAL
{
    internal class TestDbContext : DbContext
    {

        public DbSet<AudioBooks>? Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();
            string? connectionString = configuration.GetConnectionString("constr");

            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}

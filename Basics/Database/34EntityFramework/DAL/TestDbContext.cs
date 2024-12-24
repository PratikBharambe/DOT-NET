

using System.Linq;
using _34EntityFramework.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace _34EntityFramework.DAL
{
    internal class TestDbContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            string connectionString = config.GetConnectionString("conStr");

            optionsBuilder.UseSqlServer(connectionString);
        }

        public Employee GetEmployeeById(int id)
        {
            var idParam = new SqlParameter("@Id", id);
            #pragma warning disable CS8603
            return Employees.FromSqlRaw("EXEC GetEmployeeById @ID", idParam)
                .AsEnumerable().FirstOrDefault();
            #pragma warning restore CS8603
        }

        public List<Employee> GetEmployeesByAddressStartsWith(string StartLetter)
        {
            var StartLetterParam = new SqlParameter("@StartLetter", StartLetter);
            return Employees.FromSqlRaw("EXEC GetEmployeesByAddressStartsWith @StartLetter", StartLetterParam)
                .AsEnumerable().ToList();
        }

    }
}

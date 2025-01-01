using _06EEntityFrameworkCodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

namespace _06EEntityFrameworkCodeFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<TestDbContext>(
                options => options.UseSqlServer("Name=constr")
                );
            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movies}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}

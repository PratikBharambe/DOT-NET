namespace _02DefaultController
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); 
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //app.MapDefaultControllerRoute();

            // Conventional Routing
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Admin}/{action=Index}/{id?}"
            //    );

            app.Run();
        }
    }
}

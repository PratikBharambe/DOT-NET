namespace _01_MVCBasics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Welcome to MVC version 6.0");
                await next (context);
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("\n Hello..! there L this side");
            });
            app.Run();
        }
    }
}

using AudioBook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace AudioBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDistributedMemoryCache();

            builder.Services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" }); });

            builder.Services.AddDbContext<AudioBookContext>(
                options => options.UseSqlServer("name=conStr")
                );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors((policyBuilder) =>
            {
                policyBuilder.WithOrigins("*").WithHeaders("*").WithMethods("*");
            });

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

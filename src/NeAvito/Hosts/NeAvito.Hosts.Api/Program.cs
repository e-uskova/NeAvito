using Microsoft.OpenApi.Models;
using NeAvito.Contracts.User;
using NeAvito.Hosts.Api.Controllers;
using NeAvito.Infrastructure.ComponentRegistrar;

namespace NeAvito.Hosts.Api
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
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "NeAvito", Version = "v1" });

                var docTypeMarkers = new[]
                {
                    typeof(UserDto),
                    typeof(UserController),
                };

                foreach (var marker in docTypeMarkers)
                {
                    var xmlFile = $"{marker.Assembly.GetName().Name}.xml";
                    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                    if (File.Exists(xmlPath))
                    {
                        options.IncludeXmlComments(xmlPath);
                    }
                }
            });

            builder.Services.AddServices();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
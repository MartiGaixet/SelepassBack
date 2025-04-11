using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using SelepassBack.Models;
using SelepassBack.Repositories;
using SelepassBack.Services;

namespace SelepassBack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = "Server=localhost,1433;Database=selepass;User Id=sa;Password=Selepass69!;TrustServerCertificate=True;";
            builder.Services.AddDbContext<Context>(options =>
                options.UseSqlServer(connectionString));


            builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            builder.Services.AddScoped<IUsuarioService, UsuarioService>();
            builder.Services.AddScoped<IExamenRepository, ExamenRepository>();
            builder.Services.AddScoped<IExamenService, ExamenService>();
            builder.Services.AddScoped<IApuntesRepository, ApuntesRepository>();
            builder.Services.AddScoped<IApuntesService, ApuntesService>();
            builder.Services.AddScoped<IAsignaturaRepository, AsignaturaRepository>();
            builder.Services.AddScoped<IAsignaturaService, AsignaturaService>();

            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
                    options.JsonSerializerOptions.WriteIndented = true;
                });


            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins", policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseCors("AllowAllOrigins");

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
using Campany.amar.BLL.Interfaces;
using Campany.amar.BLL.Repositories;
using Campany.amar.DAL.Data.Context;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;

namespace Campany.amar.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // Register Built-in MVC Services
            builder.Services.AddScoped<IDepartmentRepository,DepartmentRepository>(); //Allow DI For DepartmentRepository
            builder.Services.AddDbContext<CampanyDbContext>(Options => {

                Options.UseSqlServer(builder.Configuration.GetConnectionString("DefauitConnections"));
             
            
            
            
            });// Allow DI for CampanyDbContext
            
            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

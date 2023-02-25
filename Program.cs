using System.Configuration;
using Crud_MVC.Data;
using Microsoft.EntityFrameworkCore;


namespace Crud_MVC
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<Banco>
            (options => options.UseSqlServer("Server=(local)\\sqlexpress;DataBase=CRUD_Repositorios;Trusted_Connection=True;MultipleActiveResultSets=True"));
            // "Server = myServerAddress; Database = myDataBase; Trusted_Connection = True; "));

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
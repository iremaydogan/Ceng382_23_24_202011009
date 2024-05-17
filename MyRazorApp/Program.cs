// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Hosting;

// namespace MyRazorApp
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             CreateHostBuilder(args).Build().Run();
//         }

//         public static IHostBuilder CreateHostBuilder(string[] args) =>
//             Host.CreateDefaultBuilder(args)
//                 .ConfigureWebHostDefaults(webBuilder =>
//                 {
//                     webBuilder.ConfigureServices(services =>
//                     {
//                         services.AddRazorPages(); // Razor Pages servisini ekleyin
//                         // İhtiyacınıza göre diğer servisleri ekleyin
//                     });

//                     webBuilder.Configure(app =>
//                     {
//                         app.UseHttpsRedirection();
//                         app.UseStaticFiles();

//                         app.UseRouting();

//                         app.UseAuthorization();

//                         app.UseEndpoints(endpoints =>
//                         {
//                             endpoints.MapRazorPages(); // Razor Pages endpoint'ini ekle
//                             // İhtiyacınıza göre diğer endpoint'leri ekleyin
//                         });
//                     });
//                 });
//     }
// }
using Microsoft.EntityFrameworkCore;
using MyRazorApp.Data;
using MyRazorApp.Models;  // Data ad alanını kullanın

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<Ceng382Context>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

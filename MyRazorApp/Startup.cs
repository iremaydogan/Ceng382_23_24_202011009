// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.DependencyInjection;

// namespace MyRazorApp
// {
//     public class Startup
//     {
//         public void ConfigureServices(IServiceCollection services)
//         {
//             services.AddRazorPages();
//             // Diğer servisleri ekleme
//         }

//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }
//             else
//             {
//                 app.UseExceptionHandler("/Error");
//                 app.UseHsts();
//             }

//             app.UseHttpsRedirection();
//             app.UseStaticFiles();

//             app.UseRouting();

//             app.UseAuthorization();

//             app.UseEndpoints(endpoints =>
//             {
//                 endpoints.MapRazorPages();
//                 // Diğer endpoint'leri ekleme
//             });
//         }
//     }
// }

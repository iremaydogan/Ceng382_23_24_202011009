// public class Startup
// {
//     public void ConfigureServices(IServiceCollection services)
//     {
//         services.AddSingleton<ILogger, FileLogger>();
//         services.AddSingleton<IReservationRepository, ReservationRepository>();
//         services.AddTransient<IReservationService, ReservationService>();

//         // Web API veya MVC için gerekli yapılandırmalar
//         services.AddControllers();  // Web API için
//         // services.AddMvc(); // MVC için
//     }

//     public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//     {
//         if (env.IsDevelopment())
//         {
//             app.UseDeveloperExceptionPage();
//         }

//         app.UseRouting();

//         app.UseEndpoints(endpoints =>
//         {
//             endpoints.MapControllers();  // Web API için
//             // endpoints.MapDefaultControllerRoute(); // MVC için
//         });
//     }
// }

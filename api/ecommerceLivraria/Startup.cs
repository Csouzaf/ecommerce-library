
// using ecommerceLivraria.Models;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Http;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.InMemory;


// namespace ecommerceLivraria
// {
//     public class Startup
//     {
//         public Startup(IConfiguration configuration)
//         {
//             Configuration = configuration;
//         }

//         public IConfiguration Configuration { get; }

//         // This method gets called by the runtime. Use this method to add services to the container.
//         public void ConfigureServices(IServiceCollection services)
//         {
//            services.AddControllers();
//            services.AddDbContext<ToDoContextModel>(opt => opt.UseInMemoryDatabase(databaseName: "produtos"));
        
//             services.AddTransient<ToDoContextModel>();

//         }

//         // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//         {
//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//             }
//             else
//             {
//                 app.UseExceptionHandler("/Home/Error");
//                 app.UseHsts();
//             }

//             app.UseHttpsRedirection();
//             app.UseStaticFiles();

//             app.UseRouting();
//             app.UseAuthorization();

//             app.UseEndpoints(endpoints =>
//             {
//                 endpoints.MapControllerRoute(
//                     name: "default",
//                     pattern: "{controller=Home}/{action=Index}/{id?}");
//             });
//         }
//     }
// }


// // namespace ecommerceLivraria

// // {
// //     public class Startup
// //     {
// //          public void ConfigureServices(IServiceCollection services)
// //         {
// //            services.AddDbContext<ToDoContext>(options => options.UseInMemoryDatabase("produtos"));
// //            services.AddControllers();
// //         }

// //         public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
// //         {
// //             if (env.IsDevelopment())
// //             {
// //                 app.UseDeveloperExceptionPage();
// //             }

// //             app.UseRouting();

// //             app.UseEndpoints(endpoints =>
// //             {
// //                 endpoints.MapControllers();
// //             });
// //         }
// //     }
// // }

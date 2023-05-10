
using ecommerceLivraria.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ToDoContextModel>(options =>
    options.UseInMemoryDatabase("ToDoList"));

builder.Services.AddCors(options => 
{
    options.AddDefaultPolicy( builder => 
    {
         options.AddPolicy("AllowAnyOrigin", builder =>
         builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            // builder.WithOrigins("http://localhost:4200")
            //        .AllowAnyHeader()
            //        .AllowAnyMethod();
    });
        
});

builder.Services.AddControllersWithViews();


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


app.UseCors("AllowAnyOrigin");
// app.UseCors("http://localhost:4200");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

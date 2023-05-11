
using ecommerceLivraria.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// // cria um novo contexto
// var newContext = new ToDoContextModel(options);

// // exclui todos os dados do contexto antigo
// newContext.Database.EnsureDeleted();

// // cria novamente o banco de dados
// newContext.Database.EnsureCreated();

builder.Services.AddDbContext<ToDoContextModel>(options =>
    options.UseInMemoryDatabase(databaseName: "ToDoList"));

builder.Services.BuildServiceProvider();


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

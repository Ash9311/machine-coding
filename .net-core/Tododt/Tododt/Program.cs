using Microsoft.EntityFrameworkCore;
using TodoListProject.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var Configuration = builder.Configuration;
builder.Services.AddDbContext<TodoContext>(options =>
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
//builder.Services.AddStackExchangeRedisCache(options =>
//{
//    options.Configuration = Configuration["Redis:Configuration"];
//}
//);

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

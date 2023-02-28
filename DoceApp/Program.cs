//using DoceApp.Context;
//using DoceApp.Interface;
//using DoceApp.Repositório;
using DoceApp.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
//builder.Services.AddDbContext<DoceAppContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DoceAppDatabase"));

//});
//builder.Services.AddScoped<ILogin, LoginRepository>();
//builder.Services.AddScoped<IPeople, PeopleRepository>();
//builder.Services.AddScoped<IConfectionery, ConfectioneryRepository>();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

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

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Login}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Register}");

app.Run();

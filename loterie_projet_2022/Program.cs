using DataLayer;
using loterie_projet_2022.services.Interfaces;
using loterie_projet_2022.services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("primaryDb");

builder.Services.AddDbContext<LoterieDbContext>(options =>
{
    //Connection string :
    options.UseSqlServer(connectionString);

    //True log pas en Prod
    options.EnableSensitiveDataLogging(true);

});

// Add services to the container.
builder.Services.AddScoped<IGameService, GameService>();
builder.Services.AddScoped<IResultService, ResultService>();
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

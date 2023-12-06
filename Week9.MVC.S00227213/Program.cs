using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Week9.MVC.S00227213.Data;
using Week9.MVC.S00227213.Models;
using Tracker.WebAPIClient;
using ClubModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using Week9.MVC.S00227213;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("Week9LabConnection") ?? throw new InvalidOperationException("Connection string 'Week9LabConnection' not found.");

builder.Services.AddDbContext<Week9DbContext>(options =>
    options.UseSqlServer(connectionString));

// Add Identity services to the container.
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Week9DbContext>()
    .AddDefaultTokenProviders();

// Add services for MVC and Razor Pages.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages(); // Add this line to register Razor Pages services

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        var dbContext = services.GetRequiredService<Week9DbContext>();

        await SeedData.Initialize(services);

        // Track activity with student ID and name
        ActivityAPIClient.Track(StudentID: "s00227213", StudentName: "Jack Monaghan",
                                activityName: "RAD301 Week 9 Lab 2223", Task: "Testing Club controller");
    }
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Map routes for both controllers and Razor Pages.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

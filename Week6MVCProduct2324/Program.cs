
using Tracker.WebAPIClient;
using Microsoft.EntityFrameworkCore;
using Week6MVCProduct2324.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register ApplicationDbContext with the DI container
var connectionString = builder.Configuration.GetConnectionString("Week6MVCProduct23-S00227213") ?? throw new InvalidOperationException("Connection string 'Week6MVCProduct23-S00227213' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Change the Activity tracker message to "Seeding Application Table Data"
ActivityAPIClient.Track(
    StudentID: "S00227213",
    StudentName: "Jack Monaghan",
    activityName: "Rad301 23 Week 6 Lab 1",
    Task: "Logging in as Authenticated user"
);

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

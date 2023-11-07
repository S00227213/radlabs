using Tracker.WebAPIClient;
using Microsoft.EntityFrameworkCore;
using Week6MVCProduct2324.Data;
using Week6MVCProduct2324.BusinessData;
using Week6MVCProduct2324;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register ApplicationDbContext with the DI container
var appConnectionString = builder.Configuration.GetConnectionString("Week6MVCProduct23-S00227213") ?? throw new InvalidOperationException("Connection string 'Week6MVCProduct23-S00227213' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(appConnectionString));

// Register BusinessContext with the DI container
var businessConnectionString = builder.Configuration.GetConnectionString("BusinessContextConnection") ?? throw new InvalidOperationException("Connection string 'BusinessContextConnection' not found.");
builder.Services.AddDbContext<BusinessContext>(options =>
    options.UseSqlServer(businessConnectionString));

var app = builder.Build();

ActivityAPIClient.Track(
    StudentID: "S00227213",
    StudentName: "Jack Monaghan",
    activityName: "Rad301 23 Week 6 Lab 1",
    Task: "Creating and Seeding Business Context"
);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

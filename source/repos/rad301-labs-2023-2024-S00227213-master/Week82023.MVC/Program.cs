using ClubModels; 
using Microsoft.EntityFrameworkCore;
using Tracker.WebAPIClient; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ClubsContext>(options =>
    options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=rad301labs20232024;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"));
builder.Services.AddControllersWithViews();

var app = builder.Build();

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


ActivityAPIClient.Track(StudentID: "s00227213", StudentName: "Jack Monaghan", activityName: "RAD301 Week 8 Lab 2223", Task: "Creating Customized Views");

app.Run();

using Microsoft.AspNetCore.Identity;

namespace Week9.MVC.S00227213
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            // Create a user
            var user = new IdentityUser { UserName = "admin@example.com", Email = "admin@example.com" };
            await userManager.CreateAsync(user, "Password123!");

            // Enroll the user in the Admin role
            await userManager.AddToRoleAsync(user, "Admin");
        }
    }
}


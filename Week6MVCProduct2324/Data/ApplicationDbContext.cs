using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Week6MVCProduct2324.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties for your entities go here
        // Example: public DbSet<YourEntity> YourEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            IdentityUser identityUser = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "paul.powell@atu.ie",
                EmailConfirmed = true,
                UserName = "paul.powell@atu.ie",
                NormalizedUserName = "PAUL.POWELL@ATU.IE",
                SecurityStamp = Guid.NewGuid().ToString(),
            };
            //set user password
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            identityUser.PasswordHash = ph.HashPassword(identityUser, "Rad301$123");
            builder.Entity<IdentityUser>().HasData(identityUser);

            // Create an admin Role
            IdentityRole identityRole = new()
            {
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            };
            builder.Entity<IdentityRole>().HasData(identityRole);

            // Put the Seeded user in that Role.
            IdentityUserRole<string> identityUserRole = new()
            {
                RoleId = identityRole.Id,
                UserId = identityUser.Id
            };
            builder.Entity<IdentityUserRole<string>>().HasData(identityUserRole);
        }
    }
}

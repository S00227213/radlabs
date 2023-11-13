using Microsoft.EntityFrameworkCore;
using System;
using ProductModel;
using Microsoft.Extensions.Logging;

namespace Week3ClubDomain23.BusinessModel
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierProduct> SupplierProducts { get; set; }

        public ProductDBContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Hard code or use the configuration manager
            // var myconnectionstring = ConfigurationManager.ConnectionStrings["Week3ConnectionString"].ConnectionString;
            var myconnectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB; Initial Catalog = WeekSampleDB-POWELL";
            optionsBuilder.UseSqlServer(myconnectionstring)
                          .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
                          .EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Primary key configuration
            modelBuilder.Entity<Category>().HasKey(e => e.CategoryID);
            modelBuilder.Entity<Product>().HasKey(e => e.ProductID);
            modelBuilder.Entity<Supplier>().HasKey(e => e.SupplierID);
            modelBuilder.Entity<SupplierProduct>().HasKey(e => new { e.ProductID, e.SupplierID });

            // Referential integrity constraints
            modelBuilder.Entity<Product>()
                .HasOne(p => p.associatedCategory)
                .WithMany(c => c.Products);

            modelBuilder.Entity<SupplierProduct>()
                .HasOne(sp => sp.FK_Supplier)
                .WithMany(s => s.SupplierProducts)
                .HasForeignKey(sp => sp.SupplierID);

            modelBuilder.Entity<SupplierProduct>()
                .HasOne(sp => sp.FK_Product)
                .WithMany(p => p.SupplierProducts)
                .HasForeignKey(sp => sp.ProductID);

            // Seeding logic
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Description = "Hardware" },
                new Category { CategoryID = 2, Description = "Appliance" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, Description = "3 inch nails", QuantityInStock = 200, CategoryID = 1, UnitPrice = 5.1m },
                new Product { ProductID = 2, Description = "Hammer", QuantityInStock = 50, CategoryID = 1, UnitPrice = 10.0m },
                new Product { ProductID = 3, Description = "Saw", QuantityInStock = 150, CategoryID = 1, UnitPrice = 20.0m },
                new Product { ProductID = 4, Description = "Washing Machine", QuantityInStock = 100, CategoryID = 2, UnitPrice = 300.0m },
                new Product { ProductID = 5, Description = "Dish Washer", QuantityInStock = 80, CategoryID = 2, UnitPrice = 250.0m }
            );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { SupplierID = 1, SupplierName = "Joe Blog", SupplierAddressLine1 = "Main St", SupplierAddressLine2 = null },
                new Supplier { SupplierID = 2, SupplierName = "Peter Pan", SupplierAddressLine1 = "Neverland", SupplierAddressLine2 = null }
            );

            modelBuilder.Entity<SupplierProduct>().HasData(
                new SupplierProduct { SupplierID = 1, ProductID = 1, DateFirstSupplied = new DateTime(2023, 2, 10) },
                new SupplierProduct { SupplierID = 1, ProductID = 2, DateFirstSupplied = new DateTime(2023, 3, 12) },
                new SupplierProduct { SupplierID = 2, ProductID = 2, DateFirstSupplied = new DateTime(2023, 1, 5) },
                new SupplierProduct { SupplierID = 2, ProductID = 3, DateFirstSupplied = new DateTime(2023, 2, 15) }
            );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace DataModel
{
    public class ProductDBContext : DbContext
    {
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

       
        public ProductDBContext()
        {
            
        }
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Hard code or use the configuration manager
            var myconnectionstring = ConfigurationManager.ConnectionStrings["Week3SampleAppConnection"].ConnectionString;
            //var myconnectionstring = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = WeekSampleDB-PPOWELL";
            optionsBuilder.UseSqlServer(myconnectionstring)
              .LogTo(Console.WriteLine,
                     new[] { DbLoggerCategory.Database.Command.Name },
                     LogLevel.Information).
                        EnableSensitiveDataLogging(true);

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define Primary Keys Default convention is Identity column for 
            // int based Keys
            modelBuilder.Entity<Category>( e=> {
                e.HasKey(e => e.CategoryID);
                e.Property(k => k.CategoryID)
                .UseIdentityColumn(1, 1);
            });

            modelBuilder.Entity<Product>()
                .HasKey(e => e.ProductID);

            modelBuilder.Entity<Category>()
                .HasData(new Category[] {
                new Category { CategoryID=1, Description="Hardware" },
                new Category { CategoryID=2, Description="Electrical Appliances" }
                    }
                );
            modelBuilder.Entity<Product>()
                .HasData(new Product[] {
                    new Product { ProductID=1,Description="9 inch nails", QuantityInStock=200, dateFirstIssued=new DateTime(2019,12,07).AddDays(6), CategoryID=1, UnitPrice= 0.1f},
                    new Product { ProductID=2,Description="9 inch bolts", QuantityInStock=120, dateFirstIssued=new DateTime(2019,12,15).AddDays(2), CategoryID=1, UnitPrice= 0.2f},
                    new Product { ProductID=3,Description="Chimney Hoover", QuantityInStock=10,dateFirstIssued=new DateTime(2019,12,10).AddDays(11), CategoryID=2, UnitPrice= 100.5f},
                    new Product { ProductID=4,Description="Wassing Machine", QuantityInStock=7,dateFirstIssued=new DateTime(2019,12,09).AddDays(11), CategoryID=2, UnitPrice= 399.99f},

                });
            base.OnModelCreating(modelBuilder);
        }


    }
}



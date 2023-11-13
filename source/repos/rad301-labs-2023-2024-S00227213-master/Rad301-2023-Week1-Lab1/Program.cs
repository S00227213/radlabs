using System;
using System.Collections.Generic;
using System.Linq;

namespace Rad301_2023_Week1_Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Designing classes Model"); // Track message
            Console.WriteLine("Starting Queries");

            var productModel = new ProductModel
            {
                Suppliers = new List<ProductModel.Supplier>
                {
                    new ProductModel.Supplier { SupplierID = 1, SupplierName = "Parts 1", Addr1 = "Addr 11", Addr2 = "Addr 21" },
                    new ProductModel.Supplier { SupplierID = 2, SupplierName = "Parts 2", Addr1 = "Addr 11", Addr2 = "Addr 21" }
                },
                Products = new List<ProductModel.Product>
                {
                    new ProductModel.Product { ProductID = 1, Description = "9’’ Nails", Qty = 200, UnitPrice = 0.10f, CategoryID = 1 },
                    new ProductModel.Product { ProductID = 2, Description = "9’’ Bolts", Qty = 120, UnitPrice = 0.20f, CategoryID = 1 },
                    new ProductModel.Product { ProductID = 3, Description = "Chimney Hoover", Qty = 10, UnitPrice = 100.50f, CategoryID = 2 },
                    new ProductModel.Product { ProductID = 4, Description = "Washing Machine", Qty = 7, UnitPrice = 399.99f, CategoryID = 2 }
                },
                Categories = new List<ProductModel.Category>
                {
                    new ProductModel.Category { Id = 1, Description = "Hardware" },
                    new ProductModel.Category { Id = 2, Description = "Electrical Appliances" }
                },
                SupplierProducts = new List<ProductModel.SupplierProduct>
                {
                    new ProductModel.SupplierProduct { SupplierID = 1, ProductID = 1, DateFirstSupplied = DateTime.Parse("12/12/2012") },
                    new ProductModel.SupplierProduct { SupplierID = 1, ProductID = 2, DateFirstSupplied = DateTime.Parse("06/01/2013") },
                    new ProductModel.SupplierProduct { SupplierID = 2, ProductID = 3, DateFirstSupplied = DateTime.Parse("09/09/2017") },
                    new ProductModel.SupplierProduct { SupplierID = 2, ProductID = 4, DateFirstSupplied = DateTime.Parse("10/09/2017") }
                }
            };

            // Query 12: List all the categories
            var allCategories = productModel.Categories;
            Console.WriteLine("All Categories:");
            foreach (var category in allCategories)
            {
                Console.WriteLine(category.Description);
            }

            // Query 13: List all the Products
            var allProducts = productModel.Products;
            Console.WriteLine("\nAll Products:");
            foreach (var product in allProducts)
            {
                Console.WriteLine(product.Description);
            }

            // Query 14: List Products with Quantity <= 100
            var lowQuantityProducts = productModel.Products
                .Where(p => p.Qty <= 100)
                .ToList();
            Console.WriteLine("\nProducts with Quantity <= 100:");
            foreach (var product in lowQuantityProducts)
            {
                Console.WriteLine(product.Description);
            }

            // Query 15: List all the Products together with their total value
            var productsWithTotalValue = productModel.Products
                .Select(p => new
                {
                    Description = p.Description,
                    TotalValue = p.Qty * p.UnitPrice
                })
                .ToList();
            Console.WriteLine("\nProducts with Total Value:");
            foreach (var product in productsWithTotalValue)
            {
                Console.WriteLine($"{product.Description} - Total Value: {product.TotalValue:C}");
            }

            // Query 16: List all the Products in the Hardware Category
            var hardwareProducts = productModel.Products
                .Where(p => p.CategoryID == productModel.Categories.FirstOrDefault(c => c.Description == "Hardware")?.Id)
                .ToList();
            Console.WriteLine("\nHardware Products:");
            foreach (var product in hardwareProducts)
            {
                Console.WriteLine(product.Description);
            }

            // Query 17: List all the suppliers and their Parts ordered by supplier name
            var suppliersAndParts = productModel.Suppliers
                .Join(productModel.SupplierProducts, s => s.SupplierID, sp => sp.SupplierID, (s, sp) => new
                {
                    SupplierName = s.SupplierName,
                    Description = productModel.Products.FirstOrDefault(p => p.ProductID == sp.ProductID)?.Description
                })
                .OrderBy(s => s.SupplierName)
                .ToList();
            Console.WriteLine("\nSuppliers and Parts ordered by Supplier Name:");
            foreach (var item in suppliersAndParts)
            {
                Console.WriteLine($"{item.SupplierName} - Part: {item.Description}");
            }

            Console.WriteLine("\nAll Queries Completed.");
            Console.ReadKey();
        }
    }
}

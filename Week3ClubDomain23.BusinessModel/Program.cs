using Week3ClubDomain23.BusinessModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Week3ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ProductDBContext db = new ProductDBContext())
            {
                db.Categories.Add(new Category
                {
                    Description = "Accessories",
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Description="Bow Tie",
                            dateFirstIssued = DateTime.Now,
                            QuantityInStock = 200,
                            UnitPrice = 12.99f
                        }
                    }
                });

                db.SaveChanges();

                foreach (var item in db.Categories.Include(p => p.Products))
                {
                    Console.WriteLine($"{item.Description}");
                    foreach (var product in item.Products)
                    {
                        Console.WriteLine($"    {product.Description}");
                    }
                }
                Console.ReadKey();
            }
        }
    }
}

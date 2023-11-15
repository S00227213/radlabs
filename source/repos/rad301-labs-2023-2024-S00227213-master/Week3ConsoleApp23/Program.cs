using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Week3ClubDomain23.BusinessModel;
using Tracker.WebAPIClient;
using ProductModel;


namespace Week3ClubDomain23
{
    class Program
    {
        static void Main(string[] args)
        {
            ActivityAPIClient.Track(
        StudentID: "S00227213",
        StudentName: "Jack Monaghan",
        activityName: "Rad301 23 Week 3 Lab 1",
        Task: "Seeding and using test Data"
    );


            using (ProductDBContext db = new ProductDBContext())
            {
                db.Categories.Add(new Category
                {
                    Description = "Accessories",
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Description = "Tie",
                            QuantityInStock = 200,
                            UnitPrice = 19.99M
                        }
                    }
                });
                db.SaveChanges();

                foreach (var item in db.Categories.Include(p => p.Products))
                {
                    Console.WriteLine($"{item.Description}:");
                    foreach (var product in item.Products)
                    {
                        Console.WriteLine($"\t{product.Description}");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
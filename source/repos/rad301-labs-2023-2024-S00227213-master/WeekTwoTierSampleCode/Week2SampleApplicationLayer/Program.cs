using DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Week2SampleApplicationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ProductDBContext db = new ProductDBContext(new DbContextOptions<ProductDBContext>()))
            {
                if (!db.Categories.IsNullOrEmpty())
                {
                    foreach (var item in db.Categories)
                    {
                        Console.WriteLine($"{item.Description}");
                    }
                }

            }
            Console.WriteLine("Hello, World!");
        }
    }
}
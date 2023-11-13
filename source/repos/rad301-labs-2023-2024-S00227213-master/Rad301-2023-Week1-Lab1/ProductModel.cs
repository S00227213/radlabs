using System;
using System.Collections.Generic;

namespace Rad301_2023_Week1_Lab1
{
    public class ProductModel
    {
        public List<Supplier> Suppliers { get; set; }
        public List<Product> Products { get; set; }
        public List<SupplierProduct> SupplierProducts { get; set; }
        public List<Category> Categories { get; set; }

        public ProductModel()
        {
            // Initialize empty collections
            Suppliers = new List<Supplier>();
            Products = new List<Product>();
            SupplierProducts = new List<SupplierProduct>();
            Categories = new List<Category>();
        }

        public class Supplier
        {
            public int SupplierID { get; set; }
            public string SupplierName { get; set; }
            public string Addr1 { get; set; }
            public string Addr2 { get; set; }
        }

        public class Product
        {
            public int ProductID { get; set; }
            public string Description { get; set; }
            public int Qty { get; set; }
            public float UnitPrice { get; set; }
            public int CategoryID { get; set; }
        }

        public class Category
        {
            public int Id { get; set; }
            public string Description { get; set; }
        }

        public class SupplierProduct
        {
            public int SupplierID { get; set; }
            public int ProductID { get; set; }
            public DateTime DateFirstSupplied { get; set; }
        }
    }
}

using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Sample_code.DataLayer
{
    public static class StaticDataContext
    {
        public static List<Supplier> Suppliers = new List<Supplier>()
        {
             new Supplier { SupplierID=1,
                 SupplierName="Joe bloggs",
                 SupplierAddressLine1="The Coop", 
                 SupplierAddressLine2="Copersville",
                 Products = new List<Product>()
                 {
                    new Product { ProductID=1,
                        Description="9 inch nails", 
                        QuantityInStock=200, 
                        dateFirstIssued=new DateTime(2019,12,07).AddDays(6), 
                        UnitPrice= 0.1f},
                    new Product { ProductID=2,
                        Description="9 inch bolts", 
                        QuantityInStock=120, 
                        dateFirstIssued=new DateTime(2019,12,15).AddDays(2), 
                        CategoryID=1, UnitPrice= 0.2f},
                 }
                
             },
             new Supplier { SupplierID=2,
                 SupplierName="Mary Quant",
                 SupplierAddressLine1="Priory Road", 
                 SupplierAddressLine2="Paris",
                 Products =  new List<Product>()
                 {
                    new Product { ProductID=3,Description="Chimney Hoover", QuantityInStock=10,dateFirstIssued=new DateTime(2019,12,10).AddDays(11), CategoryID=2, UnitPrice= 100.5f},
                    new Product { ProductID=4,Description="Wassing Machine", QuantityInStock=7,dateFirstIssued=new DateTime(2019,12,09).AddDays(11), CategoryID=2, UnitPrice= 399.99f},
                 }
             },
        };

    }
}

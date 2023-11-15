using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Sample_code.DataLayer
{
    public class DataService : IDataService
    {
        

        public DataService()
        {
            
        }
        public void AddSupplier(Supplier supplier)
        {
            StaticDataContext.Suppliers.Add(supplier);
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public Supplier GetSupplierById(int supplierId)
        {
            throw new NotImplementedException();
        }

        public List<Supplier> GetSuppliers()
        {
            return StaticDataContext.Suppliers;
        }
    }
}

using ProductModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Sample_code.DataLayer
{
    public interface  IDataService
    {
        List<Supplier> GetSuppliers();

        List<Product> GetProducts();

        Supplier GetSupplierById(int supplierId);
        Product GetProductById(int productId);

        void AddSupplier(Supplier supplier);
    }
}

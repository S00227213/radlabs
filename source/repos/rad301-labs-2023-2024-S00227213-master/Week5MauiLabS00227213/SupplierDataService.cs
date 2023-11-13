using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductModel;

namespace Week5MauiLabS00227213
{
    internal class SupplierDataService
    {
        private readonly IRepository<Supplier> _supplierRepository;

        public SupplierDataService(IRepository<Supplier> supplierRepository)
        {
            _supplierRepository = supplierRepository ?? throw new ArgumentNullException(nameof(supplierRepository));
        }

        public async Task<List<Supplier>> GetAllSuppliersAsync()
        {
            return await _supplierRepository.GetAll();
        }

        public async Task<Supplier> GetSupplierByIdAsync(int id)
        {
            return await _supplierRepository.Get(id);
        }

        public async Task<List<Product>> GetProductsBySupplierIdAsync(int supplierId)
        {
            var supplier = await GetSupplierByIdAsync(supplierId);
            return supplier?.Products?.ToList();
        }

        public async Task AddNewSupplierAsync(Supplier supplier)
        {
            await _supplierRepository.Add(supplier);
        }

        
        public async Task UpdateSupplierAsync(Supplier supplier)
        {
           
        }
    }
}

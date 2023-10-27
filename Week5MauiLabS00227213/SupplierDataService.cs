﻿using System;
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

        // Assuming you have a method to update Suppliers, you can update the supplier directly.
        // Note: This method assumes that the IRepository<T> interface provides an update method. If it doesn't, you'll need to add one.
        public async Task UpdateSupplierAsync(Supplier supplier)
        {
            // Here you'd call the update method for Suppliers. If IRepository doesn't have an update, you'd need to add one.
            // Example: await _supplierRepository.Update(supplier);
        }
    }
}

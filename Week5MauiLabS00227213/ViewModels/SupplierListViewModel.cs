using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Week5MauiLabS00227213;
using ProductModel;

namespace Week5MauiLabS00227213.ViewModels
{
    internal class SupplierListViewModel
    {
      
        private readonly SupplierDataService _supplierDataService;

        public ObservableCollection<Supplier> Suppliers { get; private set; }
        public ObservableCollection<Product> SelectedSupplierProducts { get; private set; }

        public Supplier SelectedSupplier { get; set; }

        public SupplierListViewModel(SupplierDataService supplierDataService)
        {
            _supplierDataService = supplierDataService;
            Suppliers = new ObservableCollection<Supplier>();
            SelectedSupplierProducts = new ObservableCollection<Product>();
        }

        public async Task LoadSuppliersAsync()
        {
            var suppliers = await _supplierDataService.GetAll();
            foreach (var supplier in suppliers)
            {
                Suppliers.Add(supplier);
            }
        }

        public void UpdateSelectedSupplierProducts()
        {
            SelectedSupplierProducts.Clear();
            if (SelectedSupplier != null)
            {
                foreach (var product in SelectedSupplier.Products)
                {
                    SelectedSupplierProducts.Add(product);
                }
            }
        }

       
    }
}

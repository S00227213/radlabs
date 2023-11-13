using Week5MauiLabS00227213.ViewModels;

namespace Week5MauiLabS00227213.Pages
{
    public partial class ListSuppliersViewPage : ContentPage
    {
        public ListSuppliersViewPage()
        {
            InitializeComponent();

            // Initialize the repository and data service
            var supplierRepository = new SupplierRepository();
            var supplierDataService = new SupplierDataService(supplierRepository);
            BindingContext = new SupplierListViewModel(supplierDataService);
        }


    }
}
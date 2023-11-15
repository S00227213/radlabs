using rad301_2023_week3_mauiApp.ViewModels;
using ProductModel;

namespace rad301_2023_week3_mauiApp.Pages
{
    public partial class CategoriesListPage : ContentPage
    {
        private CategoriesListViewModel _categoriesListViewModel;
        private IProduct<Product> _productDataService;

        public CategoriesListPage(ICategory<Category> categoryDataService, IProduct<Product> productDataService)
        {
            _productDataService = productDataService;
            CategoriesListViewModel = new CategoriesListViewModel(categoryDataService, productDataService);
            BindingContext = CategoriesListViewModel;
            InitializeComponent();
        }

        public CategoriesListViewModel CategoriesListViewModel
        {
            get => _categoriesListViewModel;
            set
            {
                _categoriesListViewModel = value;
            }
        }

        private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selection = e.CurrentSelection.FirstOrDefault();
            Category category = (Category)selection;
            // Get the first product from the selected category or change accordingly if you've a different logic
            Product selectedProduct = category.Products.FirstOrDefault();
            CategoriesListViewModel.Goto(category, selectedProduct);
        }
    }
}

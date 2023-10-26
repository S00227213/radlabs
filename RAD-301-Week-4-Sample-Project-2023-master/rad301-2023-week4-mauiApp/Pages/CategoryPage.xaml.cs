using System;
using rad301_2023_week3_mauiApp.ViewModels;

namespace rad301_2023_week3_mauiApp.Pages
{
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage(ICategory<Category> categoryDataService)
        {
            BindingContext = new CategoryViewModel(categoryDataService);
            InitializeComponent();
        }

        private async void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as Product;
            if (selectedProduct != null)
            {
                var viewModel = new CategoryProductViewModel(selectedProduct);
                var categoryProductPage = new CategoryProductsPage(viewModel);  
                await Navigation.PushAsync(categoryProductPage);
            }
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            if (BindingContext != null)
            {
                CategoryViewModel vm = (CategoryViewModel)this.BindingContext;
                vm.LoadProducts();
            }
            base.OnNavigatedTo(args);
        }
    }
}

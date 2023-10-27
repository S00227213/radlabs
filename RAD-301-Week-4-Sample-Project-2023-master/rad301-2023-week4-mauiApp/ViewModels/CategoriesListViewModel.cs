using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.Audio;
using ProductModel;
using rad301_2023_week3_mauiApp.DataLayer;
using rad301_2023_week3_mauiApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rad301_2023_week3_mauiApp.ViewModels
{
    public partial class CategoriesListViewModel : ObservableObject
    {
        public ICategory<Category> CategoryDataService { get; }
        public IProduct<Product> ProductDataService { get; }

        public CategoriesListViewModel(ICategory<Category> categoryDataService, IProduct<Product> productDataService) // Add IProduct<Product> parameter
        {
            CategoryDataService = categoryDataService;
            ProductDataService = productDataService;
            Categories = new(Task.Run(() => CategoryDataService.GetAll()).Result);
        }

        [ObservableProperty]
        ObservableCollection<Category> categories = new();

        [RelayCommand]
        public async void Goto(Category category, Product product)
        {
            // When updating a product, use the ProductService's Update method
            ProductDataService.Update(product);

            // Call the Category Page with it's associated view
            await Shell.Current.GoToAsync(nameof(CategoryPage),
                new Dictionary<string, object> { { "CurrentCategory", category } });
        }
    }
}

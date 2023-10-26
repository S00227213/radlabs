using rad301_2023_week3_mauiApp.ViewModels;

namespace rad301_2023_week3_mauiApp.Pages
{
    public partial class CategoryProductsPage : ContentPage
    {
        // Adding a property for CategoryProductViewModel
        public CategoryProductViewModel CategoryProductViewModel { get; set; }

        // Modifying the constructor to accept CategoryProductViewModel instead of ICategory<Category>
        public CategoryProductsPage(CategoryProductViewModel viewModel)
        {
            CategoryProductViewModel = viewModel;
            BindingContext = CategoryProductViewModel;
            InitializeComponent();
        }

       public CategoryViewModel CategoryViewModel
        {
            get => default;
            set
            {
            }
        }


        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            // Updating this section to work with CategoryProductViewModel
            if (CategoryProductViewModel != null)
            {
                CategoryProductViewModel vm = CategoryProductViewModel;
                
            }

            base.OnNavigatedTo(args);
        }
    }
}

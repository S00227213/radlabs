using System.ComponentModel;
using System.Collections.ObjectModel;
using ProductModel;
using System.Windows.Input;
using System;

namespace rad301_2023_week3_mauiApp
{
    public class CategoryProductViewModel : INotifyPropertyChanged
    {
        private readonly IProduct<Product> _productDataService;  // Updated this to be the correct service type

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Properties

        private Product _currentProduct;

        public Product CurrentProduct
        {
            get { return _currentProduct; }
            set
            {
                if (_currentProduct != value)
                {
                    _currentProduct = value;
                    OnPropertyChanged(nameof(CurrentProduct));
                }
            }
        }

        public ObservableCollection<Product> Products { get; set; }

        #endregion

        #region Commands

        public ICommand SaveChangesCommand { get; private set; }

        #endregion

        #region Constructor

        public CategoryProductViewModel()
        {
            Products = new ObservableCollection<Product>();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }

        public CategoryProductViewModel(Product selectedProduct, IProduct<Product> productDataService) // Updated this to be the correct service type
        {
            CurrentProduct = selectedProduct;
            _productDataService = productDataService;
            Products = new ObservableCollection<Product>();
            SaveChangesCommand = new RelayCommand(SaveChanges);
        }

        #endregion

        #region Methods

        public void LoadProductDetails()
        {
            // Fill in this placeholder with the correct method call to load product details 
            // based on your _productDataService implementation.
        }

        private void SaveChanges()
        {
            _productDataService.Update(CurrentProduct);
        }

        #endregion
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute == null || _canExecute();

        public void Execute(object parameter) => _execute();
    }
}

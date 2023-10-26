using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ProductModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using rad301_2023_week3_mauiApp.DataLayer; 

namespace rad301_2023_week3_mauiApp.ViewModels
{
    [QueryProperty("CurrentProduct", "CurrentProduct")]
    public class CategoryProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Product _currentProduct;
        public Product CurrentProduct
        {
            get { return _currentProduct; }
            set
            {
                _currentProduct = value;
                OnPropertyChanged(nameof(CurrentProduct));
            }
        }

        private ICommand _saveChangesCommand;
        public ICommand SaveChangesCommand => _saveChangesCommand ?? (_saveChangesCommand = new Command(SaveChanges));

        private readonly CategoryDataService _dataService; 

        public CategoryProductViewModel(Product selectedProduct, CategoryDataService dataService) 
            CurrentProduct = selectedProduct;
            _dataService = dataService;
        }

        private void SaveChanges()
        {
            _dataService.UpdateProduct(CurrentProduct);
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

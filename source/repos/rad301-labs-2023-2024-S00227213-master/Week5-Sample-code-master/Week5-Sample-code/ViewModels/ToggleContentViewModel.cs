using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProductModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week5_Sample_code.DataLayer;

namespace Week5_Sample_code.ViewModels
{
    public partial class ToggleContentViewModel : ObservableObject
    {
        IDataService IDataService { get; set; } 
        public ToggleContentViewModel(IDataService dataService)
        {
            IDataService = dataService;
            Suppliers = new ObservableCollection<Supplier>(IDataService.GetSuppliers());
        }

        [ObservableProperty]
        bool addingSupplier = false;

        [ObservableProperty]
        Supplier supplier = null;

        

        [RelayCommand]
        public void AddSupplier()
        {
            Supplier = new Supplier();
            AddingSupplier = true;
        }
        
        [ObservableProperty]
        ObservableCollection<Supplier> suppliers = null;

        [RelayCommand]
        public void SaveSupplier()
        {
            // Refresh suppliers
            IDataService.AddSupplier(Supplier);
            Suppliers.Add(Supplier);
            AddingSupplier = false;
            //Suppliers = new ObservableCollection<Supplier>(IDataService.GetSuppliers());
        }
        [RelayCommand]
        public void CancelAddSupplier()
        {
            Supplier = null;
            AddingSupplier = false;
        }


    }
}

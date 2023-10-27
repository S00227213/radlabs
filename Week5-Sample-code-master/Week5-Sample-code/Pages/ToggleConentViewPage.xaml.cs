using CommunityToolkit.Maui.Core.Views;
using ProductModel;
using Week5_Sample_code.DataLayer;
using Week5_Sample_code.ViewModels;

namespace Week5_Sample_code.Pages;

public partial class ToggleConentViewPage : ContentPage
{
	public ToggleConentViewPage(IDataService dataService)
	{
        BindingContext = new ToggleContentViewModel(dataService);
		InitializeComponent();
	}

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Supplier s = e.CurrentSelection.First() as Supplier;
        Shell.Current.DisplayAlert(s.SupplierName, " has " + s.Products.Count.ToString() + " products.", "Ok");
    }
}
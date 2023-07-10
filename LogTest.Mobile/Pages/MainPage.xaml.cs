using LogTest.Mobile.ViewModels;

namespace LogTest.Mobile.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
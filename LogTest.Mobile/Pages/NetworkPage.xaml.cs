using LogTest.Mobile.ViewModels;

namespace LogTest.Mobile.Pages;

public partial class NetworkPage : ContentPage
{
    private readonly NetworkViewModel _viewModel;

    public NetworkPage(NetworkViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }
}
using LogTest.Mobile.ViewModels;

namespace LogTest.Mobile.Pages;

public partial class ResultPage : ContentPage
{
	public ResultPage(ResultViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
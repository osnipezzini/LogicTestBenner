using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using LogTest.Mobile.Messengers;

namespace LogTest.Mobile.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private int? _networkLength;

    [RelayCommand]
    async Task Start()
    {
        if (!NetworkLength.HasValue)
        {
            await Shell.Current.DisplayAlert("Erro", "O tamanho da rede deve ser informado!", "OK");
        }
        else if (NetworkLength <= 0)
        {
            await Shell.Current.DisplayAlert("Erro", "O tamanho da rede deve ser positivo e maior que zero!", "OK");
        }
        else
        {
            await Shell.Current.GoToAsync($"//NetworkPage");
            WeakReferenceMessenger.Default.Send(new NetworkLengthMessage(NetworkLength.Value));
        }
    }
}

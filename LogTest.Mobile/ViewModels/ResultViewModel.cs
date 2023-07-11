using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using LogicTest.Common;

namespace LogTest.Mobile.ViewModels;

public partial class ResultViewModel : ObservableObject
{
    [ObservableProperty]
    private int? _target, _source;

    private readonly INetworkService _service;
    public ResultViewModel(INetworkService service)
    {
        _service = service;
    }
    [RelayCommand]
    async Task Check()
    {
        if (!Target.HasValue || !Source.HasValue)
        {
            await Shell.Current.DisplayAlert("Erro", "Deve ser informado o endereço das duas redes para conectar!", "OK");
        }
        else if (_service.Query(Source.Value, Target.Value))
        {
            await Utils.MakeToast($"Os pontos {Source} e {Target} estão conectados!");
            Target = Source = null;
        }
        else
        {
            await Utils.MakeToast($"Os pontos {Source} e {Target} não possuem conexão!");
            Target = Source = null;
        }        
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

using LogicTest.Common;

using LogTest.Mobile.Messengers;

namespace LogTest.Mobile.ViewModels;

[QueryProperty(nameof(NetworkLength), nameof(NetworkLength))]
public partial class NetworkViewModel : ObservableObject
{
    [ObservableProperty]
    private int? _target, _source;

    private readonly INetworkService _service;

    public NetworkViewModel(INetworkService service)
    {
        _service = service;
        WeakReferenceMessenger.Default.Register<NetworkLengthMessage>(this, (source, message) =>
        {
            _service.Init(message.Value);
        });
    }
    public string NetworkLength { get; set; }

    [RelayCommand]
    async Task Connect()
    {
        if (!Target.HasValue || !Source.HasValue)
        {
            await Shell.Current.DisplayAlert("Erro", "Deve ser informado o endereço das duas redes para conectar!", "OK");
        }
        else
        {
            try
            {
                _service.Connect(Source.Value, Target.Value);
                await Utils.MakeToast($"Os pontos {Source} e {Target} foram conectados com sucesso!");
                Target = Source = null;
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("ERRO FATAL", ex.Message, "OK");
            }
        }
    }
}

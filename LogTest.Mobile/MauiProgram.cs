using LogicTest.Common;
using LogTest.Mobile.Pages;
using LogTest.Mobile.ViewModels;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace LogTest.Mobile;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();
        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<NetworkPage>();
        builder.Services.AddTransient<ResultPage>();
        builder.Services.AddTransient<ResultViewModel>();
        builder.Services.AddTransient<NetworkViewModel>();
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddSingleton<INetworkService, NetworkService>();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}
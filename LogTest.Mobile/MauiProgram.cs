using LogicTest.Common;

using LogTest.Mobile.Pages;
using LogTest.Mobile.ViewModels;

using Microsoft.Extensions.Logging;

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
            });

        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<NetworkPage>();
        builder.Services.AddTransient<NetworkViewModel>();
        builder.Services.AddTransient<MainViewModel>();

        builder.Services.AddSingleton<INetworkService, NetworkService>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TrekordApp.View;
using TrekordApp.ViewModel;

namespace TrekordApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiMaps()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddTransient<NewLogPage>();
            builder.Services.AddTransient<NewLogPageViewModel>();
            builder.Services.AddTransient<DetailMapPage>();
            builder.Services.AddTransient<DetailMapPageViewModel>();

            return builder.Build();
        }
    }
}
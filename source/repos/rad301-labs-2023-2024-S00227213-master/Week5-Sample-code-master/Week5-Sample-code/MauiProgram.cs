using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Week5_Sample_code.DataLayer;
using Week5_Sample_code.Pages;
using Week5_Sample_code.ViewModels;

namespace Week5_Sample_code
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddTransient<ToggleConentViewPage>();   
            builder.Services.AddSingleton<IDataService,DataService>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
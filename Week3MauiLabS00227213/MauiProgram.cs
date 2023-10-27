﻿using Microsoft.Extensions.DependencyInjection; 
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;                    

namespace Week3MauiLabS00227213
{
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
                })
                .Services.AddSingleton(AudioManager.Current);  
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
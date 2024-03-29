﻿using Camera.MAUI;
using CommunityToolkit.Maui;
using FacebookLive.MVVM.ViewModel;
using Microsoft.Extensions.Logging;

namespace FacebookLive
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCameraView()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();
           
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

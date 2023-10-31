﻿using Microsoft.Extensions.Logging;

namespace TubePlayer
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
                    fonts.AddFont("FiraSans-Light.ttf", "RegularFont");
                    fonts.AddFont("FiraSans-Medium.tt", "MediumFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

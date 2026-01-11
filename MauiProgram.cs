using Microsoft.Extensions.Logging;
using ProiectMediiMobile.Pages.Salon;   // ← crucial - add this!

namespace ProiectMediiMobile
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
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            // Register ViewModel (must exist!)
            builder.Services.AddTransient<SalonViewModel>();

            // Register Page → this helps Shell resolve it (even if DI for pages in ContentTemplate is limited)
            builder.Services.AddTransient<SalonMainPage>();

            return builder.Build();
        }
    }
}
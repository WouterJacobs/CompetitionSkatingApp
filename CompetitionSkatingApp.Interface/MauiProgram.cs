using CompetitionSkatingApp.Domain.Factories;
using CompetitionSkatingApp.Domain.Interfaces;
using CompetitionSkatingApp.Interface.ViewModels;
using Microsoft.Extensions.Logging;

namespace CompetitionSkatingApp.Interface
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

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<MainPageViewModel>();
            builder.Services.AddSingleton<ICompetitionControlViewModel, CompetitionControlViewModel>();
            
            // Factories
            builder.Services.AddTransient<IEventFactory, EventFactory>();
            builder.Services.AddTransient<ICompetitionFactory, CompetitionFactory>();

#if DEBUG
            builder.Logging.AddDebug();
#endif
            

            return builder.Build();
        }
    }
}

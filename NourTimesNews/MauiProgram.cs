using Microsoft.Extensions.Logging;
using NourTimesNews.Services;
using NourTimesNews.ViewModels;

namespace NourTimesNews
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

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<DetailPage>();

            builder.Services.AddTransient<ArticlesViewModel>();
            builder.Services.AddTransient<DetailsViewModel>();

            builder.Services.AddSingleton<NewsService>();


#if DEBUG
            builder.Logging.AddDebug();

#endif

            return builder.Build();
        }
    }
}

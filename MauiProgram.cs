using OnaxDallE.MVVM.Views;
using CommunityToolkit.Maui;

namespace OnaxDallE;

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
                fonts.AddFont("Nexa-ExtraLight.ttf", "NexaExtraLight");
                fonts.AddFont("Nexa-Heavy.ttf", "NexaHeavy");
            });
		builder.Services.AddScoped<MainPage>();
        builder.Services.AddScoped<UserProfilePage>();

		//builder.Services.AddSingleton<DashboardHomePage>();

        return builder.Build();
	}
}

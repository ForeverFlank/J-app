using Microsoft.Extensions.DependencyInjection;
using J_app.Services;
using J_app.View;
using J_app.ViewModel;

namespace J_app;

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
		builder.Services.AddSingleton<LoadTable>();

        builder.Services.AddSingleton<TableViewModel>();
		builder.Services.AddTransient<DetailsViewModel>();

        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<WeekBPage>();
		builder.Services.AddTransient<DetailsPage>();

        return builder.Build();
	}
}

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using WorkbookMaui.Services;
using WorkbookMaui.ViewModels;
using WorkbookMaui.Views;


namespace WorkbookMaui;

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
		
		builder.Services.AddSingleton<INavigationService, NavigationService>();
		builder.Services.AddSingleton<DataService>();
		builder.Services.AddSingleton<WorkbookMainPageViewModel>();
		builder.Services.AddSingleton<WorkbookMainPage>();
		builder.Services.AddSingleton<WorkbookQuoteViewModel>();
		builder.Services.AddSingleton<WorkbookQuotePage>();
		
		// Set the ServiceLocator
		ServiceLocator.Services = builder.Services.BuildServiceProvider();

#if DEBUG
		builder.Logging.AddDebug();
#endif
		return builder.Build();
	}
}
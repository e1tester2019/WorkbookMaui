namespace WorkbookMaui.Services;

public class NavigationService : INavigationService
{
	private readonly IServiceProvider serviceProvider;

	public NavigationService(IServiceProvider serviceProvider)
	{
		this.serviceProvider = serviceProvider;
	}

	public async Task NavigateToAsync(string pageKey)
	{
		var pageType = Type.GetType($"YourAppNamespace.Views.{pageKey}");
		if (pageType != null)
		{
			var page = (Page)serviceProvider.GetService(pageType);
			await Shell.Current.Navigation.PushAsync(page);
		}
	}

	public async Task NavigateBackAsync()
	{
		await Shell.Current.Navigation.PopAsync();
	}
}
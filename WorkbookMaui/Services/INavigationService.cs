namespace WorkbookMaui.Services;

public interface INavigationService
{
	Task NavigateToAsync(string pageKey);
	Task NavigateBackAsync();
}
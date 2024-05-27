using System.Windows.Input;
using WorkbookMaui.Services;
using WorkbookMaui.Models;
using Microsoft.Maui.Controls;

namespace WorkbookMaui.ViewModels
{
	public class WorkbookMainPageViewModel : BaseViewModel
	{
		private readonly DataService dataService;
		private readonly INavigationService navigationService;

		public ICommand NavigateCommand { get; private set; }
		public ICommand SaveDataCommand { get; private set; }

		public string SharedData
		{
			get => dataService.ApplicationData.SharedData;
			set
			{
				dataService.ApplicationData.SharedData = value;
				OnPropertyChanged();
			}
		}

		public string WorkBookMainPageData
		{
			get => dataService.ApplicationData.WorkBookMainPageData;
			set
			{
				dataService.ApplicationData.WorkBookMainPageData = value;
				OnPropertyChanged();
			}
		}

		public WorkbookMainPageViewModel(DataService dataService, INavigationService navigationService)
		{
			this.dataService = dataService;
			this.navigationService = navigationService;

			NavigateCommand = new Command(async () => await NavigateToSecondPage());
			SaveDataCommand = new Command(async () => await SaveData());
		}

		private async Task NavigateToSecondPage()
		{
			await navigationService.NavigateToAsync("SecondView");
		}

		private async Task SaveData()
		{
			string filePath = Path.Combine(FileSystem.AppDataDirectory, "appdata.json");
			await dataService.SaveDataAsync(filePath);
		}
	}
}
using System.Text.Json;
using WorkbookMaui.Models;

namespace WorkbookMaui.Services;

public class DataService
{
	public ApplicationData ApplicationData { get; set; } = new ApplicationData();

	public async Task SaveDataAsync(string filePath)
	{
		var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 
		var _filePath = Path.Combine(desktopPath, "appdata.json");
		var json = JsonSerializer.Serialize(ApplicationData);
		await File.WriteAllTextAsync(_filePath, json);
	}

	public async Task LoadDataAsync(string filePath)
	{
		if (File.Exists(filePath))
		{
			var json = await File.ReadAllTextAsync(filePath);
			ApplicationData = JsonSerializer.Deserialize<ApplicationData>(json);
		}
	}
}
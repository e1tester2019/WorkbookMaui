using System.Text.Json;
using WorkbookMaui.Models;

namespace WorkbookMaui.Services;

public class DataService
{
	public ApplicationData ApplicationData { get; set; } = new ApplicationData();

	public async Task SaveDataAsync(string filePath)
	{
		var json = JsonSerializer.Serialize(ApplicationData);
		await File.WriteAllTextAsync(filePath, json);
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
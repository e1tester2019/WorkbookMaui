using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WorkbookMaui.ViewModels;

public class BaseViewModel : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler PropertyChanged;

	protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = null)
	{
		if (EqualityComparer<T>.Default.Equals(backingStore, value))
			return false;

		backingStore = value;
		OnPropertyChanged(propertyName);
		return true;
	}
	protected bool SetProperty<T>(T currentValue, T newValue, Action doSet, [CallerMemberName] string propertyName = null)
	{
		if (EqualityComparer<T>.Default.Equals(currentValue, newValue))
			return false;

		doSet.Invoke();
		OnPropertyChanged(propertyName);
		return true;
	}
}
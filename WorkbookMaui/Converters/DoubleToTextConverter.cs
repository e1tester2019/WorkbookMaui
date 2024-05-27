using System.Globalization;

namespace WorkbookMaui.Converters;

public class DoubleToTextConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		var number = (double) value;
		return number.Equals(0.0) ? "" : number.ToString();
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		var numberText = (string) value;
		return double.TryParse(numberText, out var number) ? number : 0.0;
	}
}
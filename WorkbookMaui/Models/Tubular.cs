using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Models;

public class Tubular : BaseViewModel
{
	private double _outerDiameter;
	private double _innerDiameter;
	private double _weight;
	private double _topDepth;
	private double _bottomDepth;
	private string _grade;
	private string _connection;
	private string _sourceList;

	public double OuterDiameter
	{
		get => _outerDiameter;
		set => SetProperty(ref _outerDiameter, value);
	}

	public double InnerDiameter
	{
		get => _innerDiameter;
		set => SetProperty(ref _innerDiameter, value);
	}

	public double Weight
	{
		get => _weight;
		set => SetProperty(ref _weight, value);
	}

	public double TopDepth
	{
		get => _topDepth;
		set => SetProperty(ref _topDepth, value);
	}

	public double BottomDepth
	{
		get => _bottomDepth;
		set => SetProperty(ref _bottomDepth, value);
	}

	public string Grade
	{
		get => _grade;
		set => SetProperty(ref _grade, value);
	}

	public string Connection
	{
		get => _connection;
		set => SetProperty(ref _connection, value);
	}

	public string SourceList
	{
		get => _sourceList;
		set => SetProperty(ref _sourceList, value);
	}
}
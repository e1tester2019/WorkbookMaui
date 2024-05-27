using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using WorkbookMaui.Models;
using WorkbookMaui.Services;

namespace WorkbookMaui.ViewModels;

public class WorkbookQuoteViewModel : BaseViewModel
{
	private readonly DataService _dataService;
	private readonly INavigationService _navigationService;
	
	public ICommand AddTubularCommand { get; private set; }
	public ICommand AddPurchaseItemsCommand { get; private set; }
	public ICommand AddRentalItemsCommand { get; private set; }
	public ICommand AddThreadPriceCommand { get; private set; }
	public ICommand AddBallPriceCommand { get; private set; }
	public ICommand SaveCommand { get; private set; }
	
	public IList<string> QuoteStatusTypes
	{
		get => _dataService.ApplicationData.QuoteStatusTypes;
		set => SetProperty(_dataService.ApplicationData.QuoteStatusTypes,value,() => _dataService.ApplicationData.QuoteStatusTypes = value);
	}
	
	public IList<string> QuoteCurrencies
	{
		get => _dataService.ApplicationData.QuoteCurrencies;
		set => SetProperty(_dataService.ApplicationData.QuoteCurrencies,value,() => _dataService.ApplicationData.QuoteCurrencies = value);
	}

	public string QuoteStatus
	{
		get => _dataService.ApplicationData.QuoteStatus;
		set => SetProperty(_dataService.ApplicationData.QuoteStatus,value,() => _dataService.ApplicationData.QuoteStatus = value);
	}

	public string QuoteCurrency
	{
		get => _dataService.ApplicationData.QuoteCurrency;
		set => SetProperty(_dataService.ApplicationData.QuoteCurrency,value,() => _dataService.ApplicationData.QuoteCurrency = value);
	}

	public ObservableCollection<Tubular> TubularInfo
	{
		get => _dataService.ApplicationData.TubularInfo;
		set => SetProperty(_dataService.ApplicationData.TubularInfo,value,() => _dataService.ApplicationData.TubularInfo = value);
	}
	
	private Tubular _selectedTubular;

	public Tubular SelectedTubular
	{
		get => _selectedTubular;
		set => SetProperty(ref _selectedTubular, value);
	}
	
	private QuoteItem _selectedPurchaseItem;
	public QuoteItem SelectedPurchaseItem
	{
		get => _selectedPurchaseItem;
		set => SetProperty(ref _selectedPurchaseItem, value);
	}

	private QuoteItem _selectedRentalItem;

	public QuoteItem SelectedRentalItem
	{
		get => _selectedRentalItem;
		set => SetProperty(ref _selectedRentalItem, value);
	}

	private ThreadPrice _selectedThreadPrice;

	public ThreadPrice SelectedThreadPrice
	{
		get => _selectedThreadPrice;
		set => SetProperty(ref _selectedThreadPrice, value);
	}
	private BallPrice _selectedBallPrice;

	public BallPrice SelectedBallPrice
	{
		get => _selectedBallPrice;
		set => SetProperty(ref _selectedBallPrice, value);
	}

	private double _visiblePurchaseItemsPrice;

	public double VisiblePurchaseItemsPrice
	{
		get => _visiblePurchaseItemsPrice;
		set => SetProperty(ref _visiblePurchaseItemsPrice, value);
	}
	
	private double _visibleRentalItemsPrice;

	public double VisibleRentalItemsPrice
	{
		get => _visibleRentalItemsPrice;
		set => SetProperty(ref _visibleRentalItemsPrice, value);
	}
	private double _visibleThreadPricePrice;

	public double VisibleThreadPricePrice
	{
		get => _visibleThreadPricePrice;
		set => SetProperty(ref _visibleThreadPricePrice, value);
	}
	private double _visibleBallPricePrice;
	public double VisibleBallPricePrice
	{
		get => _visibleBallPricePrice;
		set => SetProperty(ref _visibleBallPricePrice, value);
	}
	public ObservableCollection<QuoteItem> VisiblePurchaseItems
	{
		get => _dataService.ApplicationData.VisiblePurchaseItems;
		set => SetProperty(_dataService.ApplicationData.VisiblePurchaseItems,value,() => _dataService.ApplicationData.VisiblePurchaseItems = value);
	}
	public ObservableCollection<QuoteItem> VisibleRentalItems
	{
		get => _dataService.ApplicationData.visibleRentalItems;
		set => SetProperty(_dataService.ApplicationData.visibleRentalItems,value,() => _dataService.ApplicationData.visibleRentalItems = value);
	}
	public ObservableCollection<ThreadPrice> VisibleThreadPrices
	{
		get => _dataService.ApplicationData.VisibleThreadPrices;
		set => SetProperty(_dataService.ApplicationData.VisibleThreadPrices,value,() => _dataService.ApplicationData.VisibleThreadPrices = value);
	}
	public ObservableCollection<BallPrice> VisibleBallPrices
	{
		get => _dataService.ApplicationData.VisibleBallPrices;
		set => SetProperty(_dataService.ApplicationData.VisibleBallPrices,value,() => _dataService.ApplicationData.VisibleBallPrices = value);
	}
	public string CompletedBy
	{
		get => _dataService.ApplicationData.CompletedBy;
		set => SetProperty(_dataService.ApplicationData.CompletedBy,value,() => _dataService.ApplicationData.CompletedBy = value);
	}
	public string ApprovedBy
	{
		get => _dataService.ApplicationData.ApprovedBy;
		set => SetProperty(_dataService.ApplicationData.ApprovedBy,value,() => _dataService.ApplicationData.ApprovedBy = value);
	}
	public string ReviewedBy
	{
		get => _dataService.ApplicationData.ReviewedBy;
		set => SetProperty(_dataService.ApplicationData.ReviewedBy,value,() => _dataService.ApplicationData.ReviewedBy = value);
	}
	public DateTime EstimatedInstallDate
	{
		get => _dataService.ApplicationData.EstimatedInstallDate;
		set => SetProperty(_dataService.ApplicationData.EstimatedInstallDate,value,() => _dataService.ApplicationData.EstimatedInstallDate = value);
	}
	public DateTime EstimatedFracDate
	{
		get => _dataService.ApplicationData.EstimatedFracDate;
		set => SetProperty(_dataService.ApplicationData.EstimatedFracDate,value,() => _dataService.ApplicationData.EstimatedFracDate = value);
	}
	public DateTime QuoteDate
	{
		get => _dataService.ApplicationData.QuoteDate;
		set => SetProperty(_dataService.ApplicationData.QuoteDate,value,() => _dataService.ApplicationData.QuoteDate = value);
	}
	
	public WorkbookQuoteViewModel(DataService dataService, INavigationService navigationService)
	{
		this._dataService = dataService;
		this._navigationService = navigationService;

		AddTubularCommand = new Command(AddTubular);
		AddPurchaseItemsCommand = new Command(AddPurchaseItem);
		AddRentalItemsCommand = new Command(AddRentalItem);
		AddThreadPriceCommand = new Command(AddThreadPrice);
		AddBallPriceCommand = new Command(AddBallPrice);
		SaveCommand = new Command(async () => await SaveData());
	}

	private void AddTubular()
	{
		TubularInfo.Add( new Tubular());
	}

	private void AddPurchaseItem()
	{
		VisiblePurchaseItems.Add(new QuoteItem
		{
			IsMaster = true,
			IsInstall = true,
			IsFrac = false,
			IsAll = false,
			Index = 1,
			Header = "Sample Product",
			Description = "Description",
			BillType = "Purchase",
			BookPrice = 1110.33456,
			Discount = 0,
			UnitPrice = 1110.33456,
			Qty = 1,
			NetPrice = 1110.33456,
			Includes = string.Empty,
			IsIncludesVisible = false,
			AssociatedItems = new ObservableCollection<TallyItem>(),
			IncludedItems = new ObservableCollection<TallyItem>()
		});
	}
	private void AddRentalItem()
	{
		VisibleRentalItems.Add(new QuoteItem
		{
			IsMaster = true,
			IsInstall = true,
			IsFrac = false,
			IsAll = false,
			Index = 1,
			Header = "Sample Product",
			Description = "Description",
			BillType = "Rental",
			BookPrice = 1110.33456,
			Discount = 0,
			UnitPrice = 1110.33456,
			Qty = 1,
			NetPrice = 1110.33456,
			Includes = string.Empty,
			IsIncludesVisible = false,
			AssociatedItems = new ObservableCollection<TallyItem>(),
			IncludedItems = new ObservableCollection<TallyItem>()
		});
	}

	private void AddThreadPrice()
	{
		VisibleThreadPrices.Add( new ThreadPrice
		{
			IsMaster = true,
			IsInstall = true,
			IsFrac = false,
			IsAll = false,
			RangeStart = 0,
			RangeEnd = 1,
			Range = "0 to 1",
			BoxCost = 10,
			BoxMarkUp = 12,
			PinCost = 13,
			PinMarkUp = 14,
			ThreadCost = 15,
			TotalMarkUp = 16,
			TotalThreadCost = 17,
			Quantity = 1,
			TotalSalePrice = 99,
			Index = 1
		});
	}

	private void AddBallPrice()
	{
		VisibleBallPrices.Add( new BallPrice
		{
			IsMaster = true,
			IsInstall = false,
			IsFrac = true,
			IsAll = false,
			CasingType = "d-Solve 701 - 3.695",
			SeatIDInches = 3.555,
			SeatIDMM = 4.555,
			BallODIN = 55.998,
			BallODMM = 65.998,
			DissolveablePressureRating = 6000,
			DissolvablePressureRatingKPA = 41370,
			SalePrice = 1000,
			Index = 1,
			Quantity = 2,
			UnitPrice = 2000
		});
	}

	public void DeleteTubular(Tubular item)
	{
		if (item == null) return;
		TubularInfo.Remove(item);
	}
	
	public void DeletePurchaseItem(QuoteItem item)
	{
		if (item == null) return;
		VisiblePurchaseItems.Remove(item);
	}

	public void DeleteRentalItem(QuoteItem item)
	{
		if (item == null) return;
		VisibleRentalItems.Remove(item);
	}

	public void DeleteThreadPrice(ThreadPrice item)
	{
		if (item == null) return;
		VisibleThreadPrices.Remove(item);
	}
	
	public void DeleteBallPrice(BallPrice item)
	{
		if (item == null) return;
		VisibleBallPrices.Remove(item);
	}
	private async Task SaveData()
	{
		string filePath = Path.Combine(FileSystem.AppDataDirectory, "appdata.json");
		await _dataService.SaveDataAsync(filePath);
	}

	private void UpdateTubularsSourceCollections()
	{
		bool keyUpdated = false;

		if (Application.Current == null) return;

		foreach (var dictionary in Application.Current.Resources.MergedDictionaries)
		{
			if (dictionary.TryGetValue("SourceListOptionsTubular", out var resource))
			{
				// Log the type of the resource found
				Debug.WriteLine($"Resource found: {resource.GetType()}");

				if (resource is string[] sourceListOptions)
				{
					Debug.WriteLine("Resource is of type string[]");

					// Replace the resource with new options
					dictionary["SourceListOptionsTubular"] = new string[] { "NewOption1", "NewOption2", "NewOption3" };

					// Notify the UI about the update (if necessary)
					Debug.WriteLine("SourceListOptionsTubular updated successfully");
					keyUpdated = true;
					OnPropertyChanged();
					break;
				}
				else
				{
					Debug.WriteLine("Resource is not of type string[]");
				}
			}
			else
			{
				Debug.WriteLine("Key 'SourceListOptionsTubular' not found in this dictionary.");
			}
		}

		if (!keyUpdated)
		{
			Debug.WriteLine("Key 'SourceListOptionsTubular' not found in any merged dictionary.");
		}
	}
}
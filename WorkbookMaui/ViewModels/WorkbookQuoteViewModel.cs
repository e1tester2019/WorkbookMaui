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

	private IList<string> _quoteStatusTypes = new List<string>
	{
		"Master",
		"Install",
		"Frac"
	};
	
	public IList<string> QuoteStatusTypes
	{
		get => _quoteStatusTypes;
		set => SetProperty(ref _quoteStatusTypes, value);
	}

	private string _quoteStatus = "Master";

	public string QuoteStatus
	{
		get => _quoteStatus;
		set => SetProperty(ref _quoteStatus, value);
	}

	private ObservableCollection<Tubular> _tubularInfo = new ();

	public ObservableCollection<Tubular> TubularInfo
	{
		get => _tubularInfo;
		set => SetProperty(ref _tubularInfo, value);
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
	
	private ObservableCollection<QuoteItem> _visiblePurchaseItems = new ObservableCollection<QuoteItem>();

	public ObservableCollection<QuoteItem> VisiblePurchaseItems
	{
		get => _visiblePurchaseItems;
		set => SetProperty(ref _visiblePurchaseItems, value);
	}
	private ObservableCollection<QuoteItem> _visibleRentalItems = new ObservableCollection<QuoteItem>();

	public ObservableCollection<QuoteItem> VisibleRentalItems
	{
		get => _visibleRentalItems;
		set => SetProperty(ref _visibleRentalItems, value);
	}
	
	private ObservableCollection<ThreadPrice> _visibleThreadPrices = new ObservableCollection<ThreadPrice>();
	public ObservableCollection<ThreadPrice> VisibleThreadPrices
	{
		get => _visibleThreadPrices;
		set => SetProperty(ref _visibleThreadPrices, value);
	}

	private ObservableCollection<BallPrice> _visibleBallPrices = new ObservableCollection<BallPrice>();

	public ObservableCollection<BallPrice> VisibleBallPrices
	{
		get => _visibleBallPrices;
		set => SetProperty(ref _visibleBallPrices, value);
	}

	private string _completedBy;

	public string CompletedBy
	{
		get => _completedBy;
		set => SetProperty(ref _completedBy, value);
	}
	private string _approvedBy;

	public string ApprovedBy
	{
		get => _approvedBy;
		set => SetProperty(ref _approvedBy, value);
	}
	private string _reviewedBy;

	public string ReviewedBy
	{
		get => _reviewedBy;
		set => SetProperty(ref _reviewedBy, value);
	}

	private DateTime _estimatedInstallDate;

	public DateTime EstimatedInstallDate
	{
		get => _estimatedInstallDate;
		set => this.SetProperty(ref _estimatedInstallDate, value);
	}

	private DateTime _estimatedFracDate;

	public DateTime EstimatedFracDate
	{
		get => _estimatedFracDate;
		set => this.SetProperty(ref _estimatedFracDate, value);
	}

	private DateTime _quoteDate;

	public DateTime QuoteDate
	{
		get => _quoteDate;
		set => this.SetProperty(ref _quoteDate, value);
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
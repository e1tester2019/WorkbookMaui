using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Models;

public class QuoteItem : BaseViewModel
{
	private int _index = 1;

	private bool _isMaster = true;
	private bool _isInstall = true;
	private bool _isFrac = false;
	private bool _isAll = false;
	private bool _isIncludesVisible;
	private ObservableCollection<TallyItem> _associatedItems = new();
	private ObservableCollection<TallyItem> _includedItems = new();
	private string _header;
	private string _description;
	private string _billType;
	private double _bookPrice;
	private double _discount;
	private double _unitPrice;
	private int _qty;
	private double _netPrice;
	private string _includes;

	[DataMember]
	public bool IsMaster
	{
		get => _isMaster;
		set => SetProperty(ref _isMaster, value);
	}

	[DataMember]
	public bool IsInstall
	{
		get => _isInstall;
		set => SetProperty(ref _isInstall, value);
	}

	[DataMember]
	public bool IsFrac
	{
		get => _isFrac;
		set => SetProperty(ref _isFrac, value);
	}

	[DataMember]
	public bool IsAll
	{
		get => _isAll;
		set => SetProperty(ref _isAll, value);
	}

	[DataMember]
	public int Index
	{
		get => _index;
		set => SetProperty(ref _index, value);
	}


	[DataMember]
	public string Header
	{
		get => _header;
		set => SetProperty(ref _header, value);
	}


	[DataMember]
	public string Description
	{
		get => _description;
		set => SetProperty(ref _description, value);
	}


	[DataMember]
	public string BillType
	{
		get => _billType;
		set => SetProperty(ref _billType, value);
	}


	[DataMember]
	public double BookPrice
	{
		get => _bookPrice;
		set => SetProperty(ref _bookPrice, value);
	}


	[DataMember]
	public double Discount
	{
		get => _discount;
		set => SetProperty(ref _discount, value);
	}
	

	[DataMember]
	public double UnitPrice
	{
		get => _unitPrice;
		set => SetProperty(ref _unitPrice, value);
	}
	

	[DataMember]
	public int Qty
	{
		get => _qty;
		set { SetProperty(ref _qty, value); }
	}


	[DataMember]
	public double NetPrice
	{
		get => _netPrice;
		set => SetProperty(ref _netPrice, value);
	}


	[DataMember]
	public string Includes
	{
		get => _includes;
		set => SetProperty(ref _includes, value);
	}
	

	[DataMember]
	public bool IsIncludesVisible
	{
		get => _isIncludesVisible;
		set => SetProperty(ref _isIncludesVisible, value);
	}

	[DataMember]
	public ObservableCollection<TallyItem> AssociatedItems
	{
		get => _associatedItems;
		set => SetProperty(ref _associatedItems, value);
	}

	[DataMember]
	public ObservableCollection<TallyItem> IncludedItems
	{
		get => _includedItems;
		set => SetProperty(ref _includedItems, value);
	}
}
using System.Runtime.Serialization;
using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Models;

public class TallyItem : BaseViewModel
{
	private double _bottomDepth;
    private string _centralizer = "";
    private string _description = "";
    private string _engPortalDescription = "";
    private string _grade = "";
    private double _innerDiameter;
    private bool _isSelectable = true;
    private string _itemNum = "";
    private double _length;
    private double _outerDiameter;
    private string _operatingParams = "";
    private string _pdmNum = "";
    private string _ref = "";
    private bool _run;
    private string _serialNumber = "";
    private string _sourceList = "";
    private string _threadDown = "";
    private string _threadUp = "";
    private double _topDepth;
    private double _totalLength;
    private double _weight;
    private string _tallyRef;
    private string _tallyDescription = "";

    [DataMember]
	public bool Run
    {
        get => _run;
        set => SetProperty(ref _run, value);
    }

    private bool _isRunToggleEnabled;

    public bool IsRunToggleEnabled
    {
        get => _isRunToggleEnabled;
        set => SetProperty(ref _isRunToggleEnabled, value);
    }
    
    
    private SolidColorBrush _backgroundColor;
    public SolidColorBrush BackgroundColor
    {
        get => _backgroundColor;
        set => SetProperty(ref _backgroundColor, value);
    }

    [DataMember]
	public bool IsSelectable
    {
        get => _isSelectable;
        set => SetProperty(ref _isSelectable , value);
    }

    [DataMember]
	public string Ref
    {
        get => _ref;
        set => SetProperty(ref _ref, value);
    }

    [DataMember]
	public string Description
    {
        get => _description;
        set => SetProperty(ref _description, value);
    }

    [DataMember]
	public string TallyDescription
    {
        get => _tallyDescription;
        set => SetProperty(ref _tallyDescription, value);
    }

    [DataMember]
	public string EngPortalDescription
    {
        get => _engPortalDescription;
        set => SetProperty(ref _engPortalDescription, value);
    }

    [DataMember]
	public double Length
    {
        get => _length;
        set =>  SetProperty(ref _length, value);
    }

    [DataMember]
	public double BottomDepth
    {
        get => _bottomDepth;
        set => SetProperty(ref _bottomDepth, value);
    }

    [DataMember]
	public double TopDepth
    {
        get => _topDepth;
        set => SetProperty(ref _topDepth, value);
    }

    [DataMember]
	public double InnerDiameter
    {
        get => _innerDiameter;
        set => SetProperty(ref _innerDiameter, value);
    }

    [DataMember]
	public double OuterDiameter
    {
        get => _outerDiameter;
        set => SetProperty(ref _outerDiameter, value);
    }

    [DataMember]
	public double Weight
    {
        get => _weight;
        set => SetProperty(ref _weight, value);

    }

    [DataMember]
	public string Grade
    {
        get => _grade;
        set => SetProperty(ref _grade, value);
    }

    [DataMember]
	public string ThreadUp
    {
        get => _threadUp;
        set => SetProperty(ref _threadUp, value);
    }

    [DataMember]
	public string ThreadDown
    {
        get => _threadDown;
        set => SetProperty(ref _threadDown, value);
    }

    [DataMember]
	public string SerialNumber
    {
        get => _serialNumber;
        set => SetProperty(ref _serialNumber, value);
    }

    [DataMember]
	public string OperatingParams
    {
        get => _operatingParams;
        set => SetProperty(ref _operatingParams, value);
    }

    [DataMember]
	public string ItemNum
    {
        get => _itemNum;
        set => SetProperty(ref _itemNum, value);
    }

    [DataMember]
	public string Centralizer
    {
        get => _centralizer;
        set => SetProperty(ref _centralizer, value);
    }
    
    private bool _isSleeve;

    public bool IsSleeve
    {
        get => _isSleeve;
        set => SetProperty(ref _isSleeve, value);
    }

    private bool _isNewItem = true;

    [DataMember]
    public bool IsNewItem
    {
        get => _isNewItem;
        set => SetProperty(ref _isNewItem, value);
    }

    private double _cumulativeLength;

    [DataMember]
    public double CumulativeLength
    {
        get => _cumulativeLength;
        set => SetProperty(ref _cumulativeLength, value);
    }

    [DataMember]
	public string SourceList
    {
        get => _sourceList;
        set => SetProperty(ref _sourceList, value);
    }

    [DataMember]
	public double TotalLength
    {
        get => _totalLength;
        set => SetProperty(ref _totalLength, value);
    }

    [DataMember]
	public string PdmNum
    {
        get => _pdmNum;
        set => SetProperty(ref _pdmNum, value);
    }

    [DataMember]
	public string TallyRef
    {
        get => _tallyRef;
        set => SetProperty(ref _tallyRef, value);
    }

    private string _seatSize;

    [DataMember]
    public string SeatSize
    {
        get => _seatSize;
        set => SetProperty(ref _seatSize, value);
    }

    private string _ballSize;

    [DataMember]
    public string BallSize
    {
        get => _ballSize;
        set => SetProperty(ref _ballSize, value);
    }

    private string _ballType = "";

    [DataMember]
    public string BallType
    {
        get => _ballType;
        set => SetProperty(ref _ballType, value);
    }

    private string _ballSerial;

    [DataMember]
    public string BallSerial
    {
        get => _ballSerial;
        set => SetProperty(ref _ballSerial, value);
    }

    private string _ballLotNum;

    [DataMember]
    public string BallLotNum
    {
        get => _ballLotNum;
        set => SetProperty(ref _ballLotNum, value);
    }

    private string _calculatedVolumeToTop;

    [DataMember]
    public string CalculatedVolumeToTop
    {
        get => _calculatedVolumeToTop;
        set => SetProperty(ref _calculatedVolumeToTop, value);
    }

    private string _sleeveType;

    [DataMember]
    public string SleeveType
    {
        get => _sleeveType;
        set => SetProperty(ref _sleeveType, value);
    }

    private string _zoneLength;

    [DataMember]
    public string ZoneLength
    {
        get => _zoneLength;
        set => SetProperty(ref _zoneLength, value);
    }

    private double _packerAfter;

    [DataMember]
    public double PackerAfter
    {
        get => _packerAfter;
        set => SetProperty(ref _packerAfter, value);
    }

    private int? _quoteItemIdx;

    [DataMember]
    public int? QuoteItemIdx
    {
        get => _quoteItemIdx;
        set => SetProperty(ref _quoteItemIdx, value);
    }

    private bool? _isIncludedItem;

    [DataMember]
    public bool? IsIncludedItem
    {
        get => _isIncludedItem;
        set => SetProperty(ref _isIncludedItem, value);
    }

    private int _usages;

    [DataMember]
    public int Usages
    {
        get => _usages;
        set => SetProperty(ref _usages, value);
    }

    private double _unitPrice;

    [DataMember]
    public double UnitPrice
    {
        get => _unitPrice;
        set => SetProperty(ref _unitPrice, value);
    }

    private bool _isVisibleInMiniTallies;

    [DataMember]
    public bool IsVisibleInMiniTallies
    {
        get => _isVisibleInMiniTallies;
        set => SetProperty(ref _isVisibleInMiniTallies, value);
    }

    private bool _includeInReturnDoc = true;

    [DataMember]
    public bool IncludeInReturnDoc
    {
        get => _includeInReturnDoc;
        set => SetProperty(ref _includeInReturnDoc, value);
    }

    private string _activationType = "None";

    [DataMember]
    public string ActivationType
    {
        get => _activationType;
        set => SetProperty(ref _activationType, value);
    }

    private bool _hasError;
    
    [DataMember]
    public bool HasError
    {
        get => _hasError;
        set => SetProperty(ref _hasError, value);
    }
}
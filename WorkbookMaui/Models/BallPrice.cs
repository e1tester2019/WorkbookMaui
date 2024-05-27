using System.Runtime.Serialization;
using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Models;

public class BallPrice : BaseViewModel
{
	private string _casingType;
    private bool _isMaster = true;
    private bool _isInstall;
    private bool _isFrac = true;
    private bool _isAll;

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
    public string CasingType
    {
        get => _casingType;
        set => SetProperty(ref _casingType, value);
    }

    private double _seatIDInches;

    [DataMember]
    public double SeatIDInches
    {
        get => _seatIDInches;
        set => SetProperty(ref _seatIDInches, value);
    }

    private double _seatIDMM;

    [DataMember]
    public double SeatIDMM
    {
        get => _seatIDMM;
        set => SetProperty(ref _seatIDMM, value);
    }

    private double _ballODIN;

    [DataMember]
    public double BallODIN
    {
        get => _ballODIN;
        set => SetProperty(ref _ballODIN, value);
    }

    private double _ballODMM;

    [DataMember]
    public double BallODMM
    {
        get => _ballODMM;
        set => SetProperty(ref _ballODMM, value);
    }

    private double _dissolveablePressureRatingPSI;

    [DataMember]
    public double DissolveablePressureRating
    {
        get => _dissolveablePressureRatingPSI;
        set => SetProperty(ref _dissolveablePressureRatingPSI, value);
    }

    private double _dissolvablePressureRatingKPA;

    [DataMember]
    public double DissolvablePressureRatingKPA
    {
        get => _dissolvablePressureRatingKPA;
        set => SetProperty(ref _dissolvablePressureRatingKPA, value);
    }

    private double _salePrice;

    [DataMember]
    public double SalePrice
    {
        get => _salePrice;
        set => SetProperty(ref _salePrice, value);
    }

    private int _index;

    [DataMember]
    public int Index
    {
        get => _index;
        set => SetProperty(ref _index, value);
    }

    private int _quantity;

    [DataMember]
    public int Quantity
    {
        get => _quantity;
        set => SetProperty(ref _quantity, value);
    }

    private double _unitPrice;

    [DataMember]
    public double UnitPrice
    {
        get => _unitPrice;
        set => SetProperty(ref _unitPrice, value);
    }
    
}
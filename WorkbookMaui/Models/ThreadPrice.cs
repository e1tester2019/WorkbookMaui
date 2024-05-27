using System.Runtime.Serialization;
using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Models;

public class ThreadPrice : BaseViewModel
{
	    private bool _isMaster = true;
    private bool _isInstall = true;
    private bool _isFrac;
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
    
    private int _rangeStart;

    [DataMember]
    public int RangeStart
    {
        get => _rangeStart;
        set => SetProperty(ref _rangeStart, value);
    }

    private int _rangeEnd;

    [DataMember]
    public int RangeEnd
    {
        get => _rangeEnd;
        set => SetProperty(ref _rangeEnd, value);
    }

    private string _range;

    [DataMember]
    public string Range
    {
        get => _range;
        set => SetProperty(ref _range, value);
    }

    private double _boxCost;

    [DataMember]
    public double BoxCost
    {
        get => _boxCost;
        set => SetProperty(ref _boxCost, value);
    }

    private double _boxMarkUp;

    [DataMember]
    public double BoxMarkUp
    {
        get => _boxMarkUp;
        set => SetProperty(ref _boxMarkUp, value);
    }

    private double _pinCost;

    [DataMember]
    public double PinCost
    {
        get => _pinCost;
        set => SetProperty(ref _pinCost, value);
    }

    private double _pinMarkUp;

    [DataMember]
    public double PinMarkUp
    {
        get => _pinMarkUp;
        set => SetProperty(ref _pinMarkUp, value);
    }

    private double _threadCost;

    [DataMember]
    public double ThreadCost
    {
        get => _threadCost;
        set => SetProperty(ref _threadCost, value);
    }

    private double _totalMarkUp;

    [DataMember]
    public double TotalMarkUp
    {
        get => _totalMarkUp;
        set => SetProperty(ref _totalMarkUp, value);
    }

    private double _totalThreadCost;

    [DataMember]
    public double TotalThreadCost
    {
        get => _totalThreadCost;
        set => SetProperty(ref _totalThreadCost, value);
    }

    private int _quantity;

    [DataMember]
    public int Quantity
    {
        get => _quantity;
        set => SetProperty(ref _quantity, value);
    }

    private double _totalSalePrice;

    [DataMember]
    public double TotalSalePrice
    {
        get => _totalSalePrice;
        set => SetProperty(ref _totalSalePrice, value);
    }

    private int _index;

    [DataMember]
    public int Index
    {
        get => _index;
        set => SetProperty(ref _index, value);
    }
}
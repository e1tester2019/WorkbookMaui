using System.Collections.ObjectModel;

namespace WorkbookMaui.Models;

public class ApplicationData
{
    #region QuotePageData

    public string QuoteStatus { get; set; } = "Master";
    public string QuoteCurrency { get; set; } = "CAD";
    public IList<string> QuoteStatusTypes = new List<string>
    {
        "Master",
        "Install",
        "Frac"
    };
    public IList<string> QuoteCurrencies = new List<string>
    {
        "USD",
        "CAD",
    };
    public ObservableCollection<QuoteItem> VisiblePurchaseItems = new ObservableCollection<QuoteItem>();
    public ObservableCollection<QuoteItem> visibleRentalItems = new ObservableCollection<QuoteItem>();
    public ObservableCollection<ThreadPrice> VisibleThreadPrices = new ObservableCollection<ThreadPrice>();
    public ObservableCollection<BallPrice> VisibleBallPrices = new ObservableCollection<BallPrice>();
    public string CompletedBy;
    public string ApprovedBy;
    public string ReviewedBy;
    public DateTime EstimatedInstallDate;
    public DateTime EstimatedFracDate;
    public DateTime QuoteDate;
    
    #endregion

    #region InputPageData
    public ObservableCollection<Tubular> TubularInfo = new ();
    

    #endregion
}
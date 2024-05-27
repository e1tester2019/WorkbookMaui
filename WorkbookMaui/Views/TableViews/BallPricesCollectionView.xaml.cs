using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkbookMaui.Models;
using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Views.TableViews;

public partial class BallPricesCollectionView : ContentView
{
    public BallPricesCollectionView()
    {
        InitializeComponent();
    }
    
    private void DeleteBallPriceClicked(object sender, EventArgs e)
    {
        var button = sender as Button;

        if (button?.BindingContext is BallPrice item)
        {
            var viewModel = BindingContext as WorkbookQuoteViewModel;
            viewModel?.DeleteBallPrice(item);
        }
    }
}
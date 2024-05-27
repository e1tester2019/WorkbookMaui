using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkbookMaui.Models;
using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Views.TableViews;

public partial class ThreadPricesCollectionView : ContentView
{
    public ThreadPricesCollectionView()
    {
        InitializeComponent();
    }
    private void DeleteThreadPriceClicked(object sender, EventArgs e)
    {
        var button = sender as Button;

        if (button?.BindingContext is ThreadPrice item)
        {
            var viewModel = BindingContext as WorkbookQuoteViewModel;
            viewModel?.DeleteThreadPrice(item);
        }	
    }
}
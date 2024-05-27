using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkbookMaui.Models;
using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Views.TableViews;

public partial class TubularsCollectionView : ContentView
{
    public TubularsCollectionView()
    {
        InitializeComponent();
        
    }

    private void DeleteButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;

        if (button?.BindingContext is Tubular item)
        {
            var viewModel = BindingContext as WorkbookQuoteViewModel;
            viewModel?.DeleteTubular(item);
        }
    }
}
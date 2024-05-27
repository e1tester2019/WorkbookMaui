using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkbookMaui.Models;
using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Views.TableViews;

public partial class RentalsCollectionTableView : ContentView
{
    public RentalsCollectionTableView()
    {
        InitializeComponent();
    }
    private void DeleteRentalItemClicked(object sender, EventArgs e)
    {
        var button = sender as Button;

        if (button?.BindingContext is QuoteItem item)
        {
            var viewModel = BindingContext as WorkbookQuoteViewModel;
            viewModel?.DeleteRentalItem(item);
        }
    }
}
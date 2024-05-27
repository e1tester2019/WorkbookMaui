
using WorkbookMaui.Models;
using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Views;

public partial class WorkbookQuotePage : ContentPage
{
	public WorkbookQuotePage()
	{
		InitializeComponent();
	}
	
	public WorkbookQuotePage(WorkbookQuoteViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
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

	private void DeletePurchaseItemClicked(object sender, EventArgs e)
	{
		var button = sender as Button;

		if (button?.BindingContext is QuoteItem item)
		{
			var viewModel = BindingContext as WorkbookQuoteViewModel;
			viewModel?.DeletePurchaseItem(item);
		}
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

	private void DeleteThreadPriceClicked(object sender, EventArgs e)
	{
		var button = sender as Button;

		if (button?.BindingContext is ThreadPrice item)
		{
			var viewModel = BindingContext as WorkbookQuoteViewModel;
			viewModel?.DeleteThreadPrice(item);
		}	
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
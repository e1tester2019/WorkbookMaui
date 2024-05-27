
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
}

using WorkbookMaui.ViewModels;

namespace WorkbookMaui.Views;

public partial class WorkbookMainPage
{
	public WorkbookMainPage()
	{
		InitializeComponent();
	}

	public WorkbookMainPage(WorkbookMainPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
using J_app.Services;
using J_app.ViewModel;

namespace J_app.View;

public partial class WeekBPage : ContentPage
{
	public WeekBPage(TableViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
		viewModel.LoadTableBCommand.Execute(this);
	}
}
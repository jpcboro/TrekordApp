using TrekordApp.ViewModel;

namespace TrekordApp.View;

public partial class NewLogPage : ContentPage
{
	public NewLogPage(NewLogPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
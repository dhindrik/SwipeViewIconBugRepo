namespace SwipeMenu;

public partial class ListView : ContentPage
{
	public ListView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}

namespace SwipeMenu;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainViewModel();
	}

	
}



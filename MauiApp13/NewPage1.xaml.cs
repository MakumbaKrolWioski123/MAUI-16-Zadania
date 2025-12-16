namespace MauiApp13;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void DarkMode(object sender, ToggledEventArgs e)
    {
        Application.Current.UserAppTheme = e.Value
        ? AppTheme.Dark
        : AppTheme.Light;
    }
}

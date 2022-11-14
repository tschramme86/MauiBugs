namespace MauiBugs.Bugs.Bug003_TapGestureRecognizer;

public partial class Bug003TapGestureRecognizer : ContentPage
{
	public Bug003TapGestureRecognizer()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
		this.DisplayAlert("Tap!", "The tap works.", "Close");
    }
}
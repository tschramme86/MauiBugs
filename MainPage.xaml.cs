using MauiBugs.Data;

namespace MauiBugs;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnTapBugItem(object sender, TappedEventArgs e)
    {
		if(sender is BindableObject obj && obj.BindingContext is MauiBug bug)
		{
			Shell.Current.GoToAsync($"//bugs/{bug.Id}");
		}
    }
}


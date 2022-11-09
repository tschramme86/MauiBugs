namespace MauiBugs;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		// add all bugs from bug collection to the routing
		foreach (var bug in BugCollection.Bugs)
		{
			Routing.RegisterRoute($"//bugs/{bug.Id}", bug.BugDemoPage);
		}
	}
}

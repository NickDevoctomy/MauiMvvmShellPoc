using ShellUIPoc.Pages;

namespace ShellUIPoc;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var appShell = (AppShell)MauiProgram.MauiApp.Services.GetService(typeof(AppShell));
		MainPage = appShell;
	}
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShellUIPoc.ViewModels.Base;
using System.Windows.Input;

namespace ShellUIPoc.ViewModels;

public partial class AppShellViewModel : BaseViewModel
{
    [ObservableProperty]
    public IAsyncRelayCommand homeCommand;

    public AppShellViewModel()
    {
        HomeCommand = new AsyncRelayCommand(HomeCommandAsynchandler);
    }

    public async Task OnCurrentPageChangeAsync()
    {
        var page = Shell.Current.CurrentPage;

        //Bind menu items from page viewmodel here somehow....

        await Task.Yield();
    }

    private async Task HomeCommandAsynchandler()
    {
        await Shell.Current.GoToAsync(new ShellNavigationState("//Fruits"));
    }
}

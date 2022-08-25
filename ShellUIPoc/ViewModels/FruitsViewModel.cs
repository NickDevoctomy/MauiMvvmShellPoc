using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShellUIPoc.ViewModels.Base;

namespace ShellUIPoc.ViewModels;

public partial class FruitsViewModel : BaseAppShellPageViewModel
{
    [ObservableProperty]
    public IAsyncRelayCommand petsCommand;

    public FruitsViewModel()
    {
        petsCommand = new AsyncRelayCommand(PetsCommandAsyncHandler);
    }

    public override async Task OnAppearingAsync()
    {
        var appShellViewModel = Shell.Current.BindingContext as AppShellViewModel;
        await appShellViewModel.OnCurrentPageChangeAsync();
    }

    public override void OnSetupMenuItems()
    {
        MenuItems.Add(new MenuItem
        {
            Text = "Apple"
        });
        MenuItems.Add(new MenuItem
        {
            Text = "Orange"
        });
        MenuItems.Add(new MenuItem
        {
            Text = "Banana"
        });
        MenuItems.Add(new MenuItem
        {
            Text = "Pear"
        });
    }

    private async Task PetsCommandAsyncHandler()
    {
        await Shell.Current.GoToAsync("//Pets");
    }
}


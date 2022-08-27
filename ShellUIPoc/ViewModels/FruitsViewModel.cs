using CommunityToolkit.Mvvm.ComponentModel;
using ShellUIPoc.ViewModels.Base;
using System.Windows.Input;

namespace ShellUIPoc.ViewModels;

public partial class FruitsViewModel : BaseAppShellPageViewModel
{
    [ObservableProperty]
    public ICommand petsCommand;

    public FruitsViewModel()
    {
        petsCommand = new Command(PetsCommandHandler);
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
            Text = "Apple",
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

    private void PetsCommandHandler()
    {
        Shell.Current.GoToAsync("//Pets");
    }
}


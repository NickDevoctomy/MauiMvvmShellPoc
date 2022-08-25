using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShellUIPoc.ViewModels.Base;

namespace ShellUIPoc.ViewModels;

public partial class FruitsViewModel : BaseViewModel
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

    private async Task PetsCommandAsyncHandler()
    {
        await Shell.Current.GoToAsync("//Pets");
    }
}


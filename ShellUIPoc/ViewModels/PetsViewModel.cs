using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShellUIPoc.ViewModels.Base;

namespace ShellUIPoc.ViewModels;

public partial class PetsViewModel : BaseViewModel
{
    public override async Task OnAppearingAsync()
    {
        var appShellViewModel = Shell.Current.BindingContext as AppShellViewModel;
        await appShellViewModel.OnCurrentPageChangeAsync();
    }
}


using ShellUIPoc.ViewModels.Base;

namespace ShellUIPoc.ViewModels;

public partial class PetsViewModel : BaseAppShellPageViewModel
{
    public override async Task OnAppearingAsync()
    {
        var appShellViewModel = Shell.Current.BindingContext as AppShellViewModel;
        await appShellViewModel.OnCurrentPageChangeAsync();
    }

    public override void OnSetupMenuItems()
    {
        MenuItems.Add(new MenuItem
        {
            Text = "Cat"
        });
        MenuItems.Add(new MenuItem
        {
            Text = "Dog"
        });
        MenuItems.Add(new MenuItem
        {
            Text = "Fish"
        });
        MenuItems.Add(new MenuItem
        {
            Text = "Parrot"
        });
    }
}


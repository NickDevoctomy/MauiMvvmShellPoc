using ShellUIPoc.Pages.Base;
using ShellUIPoc.ViewModels;

namespace ShellUIPoc.Pages;

public partial class AppShell : BaseShell<AppShellViewModel>
{
    public AppShell(AppShellViewModel model)
        : base(model)
    {
        InitializeComponent();
    }
}

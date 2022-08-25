using ShellUIPoc.Pages.Base;
using ShellUIPoc.ViewModels;

namespace ShellUIPoc.Pages;

public partial class FruitsPage : BasePage<FruitsViewModel>
{
    public FruitsPage(FruitsViewModel model)
        : base(model)
    {
        InitializeComponent();
    }
}
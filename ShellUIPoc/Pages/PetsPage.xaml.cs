using ShellUIPoc.Pages.Base;
using ShellUIPoc.ViewModels;

namespace ShellUIPoc.Pages;

public partial class PetsPage : BasePage<PetsViewModel>
{
    public PetsPage(PetsViewModel model)
        : base(model)
    {
        InitializeComponent();
    }
}
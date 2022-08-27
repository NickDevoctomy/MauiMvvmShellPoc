using ShellUIPoc.Pages.Base;
using ShellUIPoc.ViewModels;
using System.Diagnostics;

namespace ShellUIPoc.Pages;

public partial class FruitsPage : BasePage<FruitsViewModel>
{
    public FruitsPage(FruitsViewModel model)
        : base(model)
    {
        InitializeComponent();
    }

    private void Button_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        Debug.WriteLine("Button Property Changed: " + e.PropertyName);
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Pets");
    }
}
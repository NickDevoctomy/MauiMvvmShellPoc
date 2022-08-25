using CommunityToolkit.Mvvm.ComponentModel;

namespace ShellUIPoc.ViewModels.Base;

[INotifyPropertyChanged]
public abstract partial class BaseViewModel
{
    public virtual Task OnAppearingAsync()
    {
        return Task.CompletedTask;
    }

    public virtual Task Return(BaseViewModel fromViewModel)
    {
        throw new NotImplementedException();
    }
}


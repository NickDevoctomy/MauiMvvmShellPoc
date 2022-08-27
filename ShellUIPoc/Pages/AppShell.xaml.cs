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

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var collectionView = sender as CollectionView;
        if(collectionView.SelectedItem != null)
        {
            collectionView.SelectedItem = null;
        }
        else
        {
            collectionView.SelectionMode = SelectionMode.None;
        }
    }

    private void CollectionView_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        var collectionView = sender as CollectionView;
        if (e.PropertyName == "SelectionMode")
        {
            if(collectionView.SelectionMode == SelectionMode.None)
            {
                collectionView.SelectionMode = SelectionMode.Single;
            }
        }
    }
}

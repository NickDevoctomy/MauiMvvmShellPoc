﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using ShellUIPoc.Pages;
using ShellUIPoc.ViewModels.Base;
using System.Diagnostics;
using System.Windows.Input;

namespace ShellUIPoc.ViewModels;

public partial class AppShellViewModel : BaseViewModel
{
    [ObservableProperty]
    public ICommand homeCommand;

    [ObservableProperty]
    public ICommand menuSelectionChangedCommand;

    [ObservableProperty]
    public ICommand menuSelectionPropertyChangedCommand;

    private BaseAppShellPageViewModel _currentPageViewModel;

    public AppShellViewModel()
    {
        HomeCommand = new Command(HomeCommandhandler);
        menuSelectionChangedCommand = new Command(MenuSelectionChangedCommandHandler);
        menuSelectionPropertyChangedCommand = new Command(MenuSelectionPropertyChangedCommandHandler);
    }

    public async Task OnCurrentPageChangeAsync()
    {
        await Task.Yield();

        var page = Shell.Current.CurrentPage;
        var nextPageViewModel = page.BindingContext as BaseAppShellPageViewModel;
        if (_currentPageViewModel != nextPageViewModel)
        {
            await RemoveMenuItems();
            _currentPageViewModel = nextPageViewModel;
            await AddMenuItems();
        }
    }

    private async Task RemoveMenuItems()
    {
        if (_currentPageViewModel == null || _currentPageViewModel.MenuItems == null)
        {
            return;
        }

        Debug.WriteLine($"Removing menu items for {_currentPageViewModel.GetType().Name}");

        var page = Shell.Current.CurrentPage;
        var appShell = Shell.Current as AppShell;
        await page.Dispatcher.DispatchAsync(() =>
        {
            foreach (var curItem in _currentPageViewModel.MenuItems)
            {
                var shellItem = curItem.Parent as ShellItem;
                appShell.Items.Remove(shellItem);
            }
        });
    }

    private async Task AddMenuItems()
    {
        if (_currentPageViewModel == null || _currentPageViewModel.MenuItems == null)
        {
            return;
        }

        Debug.WriteLine($"Adding menu items for {_currentPageViewModel.GetType().Name}");

        var page = Shell.Current.CurrentPage;
        var appShell = Shell.Current as AppShell;
        await page.Dispatcher.DispatchAsync(() =>
        {
            foreach (var curItem in _currentPageViewModel.MenuItems)
            {
                appShell.Items.Add(curItem);
            }
        });
    }

    private void HomeCommandhandler()
    {
        Shell.Current.GoToAsync(new ShellNavigationState("//Fruits"));
    }

    private void MenuSelectionChangedCommandHandler(object obj)
    {
        var collectionView = obj as CollectionView;
        if (collectionView.SelectedItem != null)
        {
            collectionView.SelectedItem = null;
        }
        else
        {
            collectionView.SelectionMode = SelectionMode.None;
        }
    }

    private void MenuSelectionPropertyChangedCommandHandler(object obj)
    {
        var collectionView = obj as CollectionView;
        if (collectionView.SelectionMode == SelectionMode.None)
        {
            collectionView.SelectionMode = SelectionMode.Single;
        }
    }
}

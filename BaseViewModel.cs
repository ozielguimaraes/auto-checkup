﻿using AutoCheckUp.Services.Navigation;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AutoCheckUp;

internal abstract partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    bool _IsBusy = false;

    public bool IsNotBusy => !IsBusy;

    protected Task Navigate<TPageViewModel>(object? parameter = null)
        where TPageViewModel : BasePageViewModel
        => NavigationService.Current.Navigate<TPageViewModel>(parameter);
}

using AutoCheckUp.Sections.Home;
using CommunityToolkit.Mvvm.Input;

namespace AutoCheckUp.Sections.Welcome;

internal sealed partial class WelcomePageViewModel : BasePageViewModel
{
    [RelayCommand]
    Task GetStarted() => Navigate<HomePageViewModel>();
}

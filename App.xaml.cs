using AutoCheckUp.Services.Navigation;

namespace AutoCheckUp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        NavigationService.Current.Initialize();
    }
}

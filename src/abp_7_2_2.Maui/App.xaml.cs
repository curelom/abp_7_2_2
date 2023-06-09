

namespace abp_7_2_2.Maui;

public partial class App : Application
{
    public App(AppShell shell)
    {
        InitializeComponent();

        MainPage = shell;
    }
}

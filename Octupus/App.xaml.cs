namespace Octupus;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // LoginPage = new AppShell();
        MainPage = new NavigationPage(new LoginPage());

    }
}

namespace BounShare;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // MainPage yerine bu yapıyı kullanıyoruz:
        return new Window(new AppShell());
    }
}
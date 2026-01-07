namespace BounShare.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private async void OnLogoutClicked(object sender, EventArgs e)
    {
        // Seni en başa, yani Login sayfasına geri atar
        await Navigation.PopToRootAsync();
    }
}
using System;

namespace BounShare.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    // Butona tıklandığında çalışacak olan metod
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Navigation.PushAsync komutu, kullanıcıyı bir sonraki sayfaya (ItemsPage) gönderir
        // Başına 'await' ekliyoruz çünkü bu bir geçiş animasyonu gerektiren işlemdir
        await Navigation.PushAsync(new ItemsPage());
    }
}
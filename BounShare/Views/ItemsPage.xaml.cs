using BounShare.Services;
using BounShare.Models;

namespace BounShare.Views;

public partial class ItemsPage : ContentPage
{
    public ItemsPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadItemsFromDatabase();
    }

    private void LoadItemsFromDatabase()
    {
        try 
        {
            using (var db = new AppDbContext())
            {
                // Veritabanının var olduğundan emin oluyoruz
                db.Database.EnsureCreated();
                
                var products = db.Items.ToList();
                
                if (products != null && products.Count > 0)
                {
                    ItemsCollectionView.ItemsSource = null;
                    ItemsCollectionView.ItemsSource = products;
                }
            }
        }
        catch (Exception ex)
        {
            Title = "Hata: " + ex.Message;
        }
    }

    // YENİ: Mesajlar butonuna tıklandığında çalışacak metod
    private async void OnMessagesClicked(object sender, EventArgs e)
    {
        // Mesajlar sayfasını (4. sayfa) açar
        await Navigation.PushAsync(new MessagesPage());
    }

    // Profil butonuna tıklandığında çalışacak metod
    private async void OnProfileClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AboutPage());
    }

    private async void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Item selectedItem)
        {
            await Navigation.PushAsync(new ItemDetailPage 
            { 
                BindingContext = selectedItem 
            });
        }

        if (sender is CollectionView collectionView)
        {
            collectionView.SelectedItem = null;
        }
    }
}
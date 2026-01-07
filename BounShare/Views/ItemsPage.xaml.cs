using BounShare.Services;
using BounShare.Models;

namespace BounShare.Views;

public partial class ItemsPage : ContentPage
{
    public ItemsPage()
    {
        InitializeComponent();
        LoadItemsFromDatabase();
    }

    private void LoadItemsFromDatabase()
    {
        using (var db = new AppDbContext())
        {
            db.Database.EnsureCreated();
            var products = db.Items.ToList();
            if (products != null)
                ItemsCollectionView.ItemsSource = products;
        }
    }

    // HATA BURADAYDI: Parametrelerin tam olarak bu şekilde olması lazım
    private async void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Item;
        
        if (selectedItem != null)
        {
            // Detay sayfasına git
            await Navigation.PushAsync(new ItemDetailPage { BindingContext = selectedItem });
        }

        // Seçimi temizle
        if (sender is CollectionView collectionView)
            collectionView.SelectedItem = null;
    }
}
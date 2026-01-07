namespace BounShare.Views;

public partial class ItemDetailPage : ContentPage
{
    public ItemDetailPage()
    {
        InitializeComponent();
    }

    private void OnRentClicked(object sender, EventArgs e)
    {
        RentButton.IsVisible = false;
        
        StatusLabel.IsVisible = true;
    }
}
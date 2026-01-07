namespace BounShare.Models;

public class Item
{
    public int Id { get; set; }
    public string Name { get; set; } // Ürün adı
    public string Category { get; set; } // Kamp, Kırtasiye vb.
    public string ImageUrl { get; set; } // Görsel linki
    public double Price { get; set; } // Günlük depozito/kiralama bedeli
}
using Microsoft.EntityFrameworkCore;
using BounShare.Models;

namespace BounShare.Services;

public class AppDbContext : DbContext
{
    // Bu satır SQL'de "Items" adında bir tablo oluşturur
    public DbSet<Item> Items { get; set; }

    // Veritabanı dosyasının telefonda/bilgisayarda nereye kaydedileceği
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "bounshare.db3");
        optionsBuilder.UseSqlite($"Filename={dbPath}");
    }

    // Sunumda "Seed Data" dediğimiz, başlangıçtaki 4 ürünümüzü ekliyoruz
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(
            new Item { Id = 1, Name = "Kamp Çadırı", Category = "Kamp", Price = 150, ImageUrl = "https://images.unsplash.com/photo-1504280390367-361c6d9f38f4" },
            new Item { Id = 2, Name = "Hesap Makinesi", Category = "Ders", Price = 50, ImageUrl = "https://images.unsplash.com/photo-1574607383476-f517f220d398" },
            new Item { Id = 3, Name = "Büyük Boy Valiz", Category = "Seyahat", Price = 100, ImageUrl = "https://images.unsplash.com/photo-1565026057447-bc90a3dceb87" },
            new Item { Id = 4, Name = "Çelik Termos", Category = "Mutfak", Price = 40, ImageUrl = "https://images.unsplash.com/photo-1517254456976-ee8682099819" }
        );
    }
}
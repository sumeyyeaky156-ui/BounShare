using Microsoft.EntityFrameworkCore;
using BounShare.Models;

namespace BounShare.Services;

public class AppDbContext : DbContext
{
    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "bounshare.db3");
        optionsBuilder.UseSqlite($"Filename={dbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(
            new Item 
            { 
                Id = 1, 
                Name = "Kamp Çadırı", 
                Category = "Kamp", 
                Price = 150, 
                ImageUrl = "https://images.pexels.com/photos/2422265/pexels-photo-2422265.jpeg?auto=compress&cs=tinysrgb&w=800" 
            },
            new Item 
            { 
                Id = 2, 
                Name = "Hesap Makinesi", 
                Category = "Ders", 
                Price = 50, 
                ImageUrl = "https://images.pexels.com/photos/6927334/pexels-photo-6927334.jpeg?auto=compress&cs=tinysrgb&w=800" 
            },
            new Item 
            { 
                Id = 3, 
                Name = "Büyük Boy Valiz", 
                Category = "Seyahat", 
                Price = 100, 
                ImageUrl = "https://images.pexels.com/photos/1008155/pexels-photo-1008155.jpeg?auto=compress&cs=tinysrgb&w=800" 
            },
            new Item 
            { 
                Id = 4, 
                Name = "Çelik Termos", 
                Category = "Mutfak", 
                Price = 40, 
                ImageUrl = "https://images.pexels.com/photos/6606315/pexels-photo-6606315.jpeg?auto=compress&cs=tinysrgb&w=800" 
            }
        );
    }
}
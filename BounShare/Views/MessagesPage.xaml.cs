using BounShare.Models;
using System.Collections.ObjectModel;

namespace BounShare.Views;

public partial class MessagesPage : ContentPage
{
    public MessagesPage()
    {
        InitializeComponent();
        LoadMessages();
    }

    private void LoadMessages()
    {
        var chatList = new List<Message>
        {
            new Message { SenderName = "Ahmet Yılmaz", ItemName = "Kamp Çadırı", LastMessage = "Merhaba, çadır hala uygun mu?", Time = "10:30", ImageUrl = "https://images.pexels.com/photos/220453/pexels-photo-220453.jpeg" },
            new Message { SenderName = "Ayşe Demir", ItemName = "Çelik Termos", LastMessage = "Yarın kütüphanede teslim alabilir miyim?", Time = "Dün", ImageUrl = "https://images.pexels.com/photos/774909/pexels-photo-774909.jpeg" },
            new Message { SenderName = "Mehmet Can", ItemName = "Hesap Makinesi", LastMessage = "Teşekkürler, çok işime yaradı.", Time = "Pazartesi", ImageUrl = "https://images.pexels.com/photos/1222271/pexels-photo-1222271.jpeg" }
        };

        MessagesCollectionView.ItemsSource = chatList;
    }
}
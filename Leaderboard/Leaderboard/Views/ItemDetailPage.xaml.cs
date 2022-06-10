using Leaderboard.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Leaderboard.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
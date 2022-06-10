using Leaderboard.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Leaderboard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeaderboardsPage : ContentPage
    {
        public LeaderboardsPage()
        {
            InitializeComponent();
            //this.BindingContext = this;
            //Items= new ObservableCollection<Item>()           
            //    {
            //        new Item { ImageSource="spongbob.png", IsIncreasing=true,
            //         Name= "David Mota", Points=1700, Sequence=1},
            //        new Item { ImageSource="spongbob.png", IsIncreasing=false,
            //         Name= "O Montana", Points=1400, Sequence=2},
            //        new Item { ImageSource="spongbob.png", IsIncreasing=true,
            //         Name= "John Doe", Points=3100, Sequence=3},
            //        new Item { ImageSource="spongbob.png", IsIncreasing=false,
            //         Name= "Think Again", Points=3200, Sequence=4},
            //        new Item { ImageSource="spongbob.png", IsIncreasing=false,
            //         Name= "What Name", Points=1200, Sequence=5},
            //        new Item { ImageSource="spongbob.png", IsIncreasing=true,
            //         Name= "New New", Points=3050, Sequence=6},
            //        new Item { ImageSource="spongbob.png", IsIncreasing=false,
            //         Name= "Old User", Points=3400, Sequence=7},
            //        new Item { ImageSource="spongbob.png", IsIncreasing=true,
            //         Name= "Last User", Points=2000, Sequence=8},
            //};
        }
    }
}
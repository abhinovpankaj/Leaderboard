using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Leaderboard.Views.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CirularFrame : ContentView
    {
        public CirularFrame()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty ImageSourceProperty =
            BindableProperty.Create(nameof(ImageSource),
            typeof(string), typeof(CirularFrame));

        public string Source
        {
            get
            {
                return (string)GetValue(ImageSourceProperty);
            }
            set
            {
                SetValue(ImageSourceProperty, value);
            }
        }
        public static readonly BindableProperty ImageWidthProperty =
            BindableProperty.Create(nameof(ImageWidthProperty),
            typeof(double), typeof(CirularFrame));

        public double ImageWidth
        {
            get
            {
                return (double)GetValue(ImageWidthProperty);
            }
            set
            {
                SetValue(ImageWidthProperty, value);
            }
        }
        public static readonly BindableProperty ImageHeightProperty =
            BindableProperty.Create(nameof(ImageSource),
            typeof(double), typeof(CirularFrame));

        public double ImageHeight
        {
            get
            {
                return (double)GetValue(ImageHeightProperty);
            }
            set
            {
                SetValue(ImageHeightProperty, value);
            }
        }

        public static readonly BindableProperty CornerRadiusProperty =
            BindableProperty.Create(nameof(CornerRadiusProperty),
            typeof(double), typeof(CirularFrame));

        public double CornerRadius
        {
            get
            {
                return (double)GetValue(CornerRadiusProperty);
            }
            set
            {
                SetValue(CornerRadiusProperty, value);
            }
        }

        public static readonly BindableProperty BadgeProperty =
            BindableProperty.Create(nameof(BadgeProperty),
            typeof(double), typeof(CirularFrame));

        public double BadgeValue
        {
            get
            {
                return (double)GetValue(BadgeProperty);
            }
            set
            {
                SetValue(BadgeProperty, value);
            }
        }
    }
}
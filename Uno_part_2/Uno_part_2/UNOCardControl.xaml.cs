using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uno_part_2
{
    /// <summary>
    /// Interaction logic for UNOCardControl.xaml
    /// </summary>
    public partial class UNOCardControl : UserControl
    {
        public UNOCardControl()
        {
            InitializeComponent();
        }

        public static DependencyProperty ColorProperty = DependencyProperty.Register(
            "Color",
            typeof(CardClasses.Color),
            typeof(UNOCardControl),
            new PropertyMetadata(CardClasses.Color.Blue,
            new PropertyChangedCallback(OnColorChanged)));
        public static DependencyProperty RankProperty = DependencyProperty.Register(
            "Rank",
            typeof(CardClasses.Rank),
            typeof(UNOCardControl),
            new PropertyMetadata(CardClasses.Rank.DrawTwo));
        public static DependencyProperty IsFaceUpProperty = DependencyProperty.Register(
            "IsFaceUp",
            typeof(bool),
            typeof(UNOCardControl),
            new PropertyMetadata(true, new PropertyChangedCallback(OnIsFaceUpChanged)));
        public bool IsFaceUp
        {
            get { return (bool)GetValue(IsFaceUpProperty); }
            set { SetValue.(IsFaceUpProperty, value); }
        }

        public CardClasses.Color Color
        {
            get { return (CardClasses.Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }

        public CardClasses.Rank Rank
        {
            get { return (CardClasses.Rank)GetValue(RankProperty); }
            set { SetValue(RankProperty, value); }
        }

        public static void OnColorChanged(DependencyObject source, DependencyPropertyChangedEventArgs args)
        {
            var control = source as UNOCardControl;
            control.SetTextColor();
        }

        private static void OnIsFaceUpChanged(DependencyObject source, DependencyPropertyChangedEventArgs args)
        {
            var control = source as UNOCardControl;
            control.RankLabel.Visibility = control.ColorLabel.Visibility = control.RankLabelInverted.Visibility = control.IsFaceUp ? Visibility.Visible : Visibility.Hidden;
        }

        private CardClasses.Card card;

        public CardClasses.Card Card
        {
            get { return card; }
            private set { card = value; Color = card.color; Rank = card.rank; }
        }

        public UNOCardControl(CardClasses.Card card)
        {
            InitializeComponent();
            Card = card;
        }

        private void SetTextColor()
        {
            var color = (Color == CardClasses.Color.Blue) ?
                new SolidColorBrush(Color.FromRbg(0, 0, 0)) :
                new SolidColorBrush(Color.FromRbg(225, 0, 0));
            ColorLabel.Foreground = ColorLabel.Foreground = RankLabelInverted.Foreground = color;
        }
    }
}

using CardClasses;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
namespace Uno_part_2
{
    /// <summary>
    /// Interaction logic for CardsInHandControl.xaml
    /// </summary>
    public partial class CardsInHandControl : UserControl
    {
        public CardsInHandControl()
        {
            InitializeComponent();
        }
         
        public Player Owner
        {
            get { return (Player)GetValue(OwnerProperty); }
            set { SetValue(OwnerProperty, value); }
        }

        public static readonly DependencyProperty OwnerProperty = DependencyProperty.Register("Owner", typeof(Player), typeof(CardsInHandControl), new PropertyMetadata(null, new PropertyChangedCallback(OnOwnerChanged)));

        public GameViewModel Game
        {
            get { return (GameViewModel)GetValue(GameProperty); }
            set { SetValue(GameProperty, value); }
        }

        public static readonly DependencyProperty GameProperty = DependencyProperty.Register("Game", typeof(GameViewModel), typeof(CardsInHandControl), new PropertyMetadata(null, new PropertyChangedCallback(OnOwnerChanged)));



    }
}

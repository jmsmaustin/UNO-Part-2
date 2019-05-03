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
using System.Windows.Shapes;

namespace Uno_part_2
{
    /// <summary>
    /// Interaction logic for UNOCard.xaml
    /// </summary>
    public partial class UNOCard : UserControl
    {
        public UNOCard()
        {
            InitializeComponent();
        }

        public static DependencyProperty ColorProperty = DependencyProperty.Register(
            "Color",
            typeof(CardClasses.Color),
            typeof(CardControl),

    }
}

using System.IO;
using System.Windows;
using System.Xml.Serialization;
using CardClasses;

namespace Uno_part_2
{
    public partial class Options : Window
    {
        private GameOptions gameOptions;

        public Options()
        {
            gameOptions = GameOptions.Create();
            DataContext = gameOptions;
            InitializeComponent();
        }

        private void dumbAIRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gameOptions.ComputerSkill = ComputerSkillLevel.Dumb;
        }

        private void goodAIRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gameOptions.ComputerSkill = ComputerSkillLevel.Good;
        }

        private void cheatingAIRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gameOptions.ComputerSkill = ComputerSkillLevel.Cheats;
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            gameOptions.Save();
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            gameOptions = null;
            Close();
        }

    }
}

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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Close)
                e.CanExecute = true;
            if (e.Command == ApplicationCommands.Save)
                e.CanExecute = false;
            if (e.Command == GameViewModel.StartGameCommand)
                e.CanExecute = true;
            if (e.Command == GameOptions.OptionsCommand)
                e.CanExecute = true;
            if (e.Command == GameViewModel.ShowAboutCommand)
                e.CanExecute = true;
            e.Handled = true;
        }
        private void CommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Close)
                this.Close();
            if (e.Command == GameViewModel.StartGameCommand)
            {
                var model = new GameViewModel();
                var startGameDialog = new StartGame();
                var options = GameOptions.Create();
                startGameDialog.DataContext = options;
                var result = startGameDialog.ShowDialog();
                if (result.HasValue && result.Value == true)
                {
                    options.Save();
                    model.StartNewGame();
                    DataContext = model;
                }
            }
            if (e.Command == GameOptions.OptionsCommand)
            {
                var dialog = new Options();
                var result = dialog.ShowDialog();
                if (result.HasValue && result.Value == true)
                    DataContext = new GameViewModel(); // Clear current game
            }
            e.Handled = true;
        }

    }
   
}

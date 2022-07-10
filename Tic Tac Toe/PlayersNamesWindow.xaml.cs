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

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for PlayersNamesWindow.xaml
    /// </summary>
    public partial class PlayersNamesWindow : Window
    {
        public PlayersNamesWindow()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(P1.Text) || string.IsNullOrEmpty(P2.Text))
            {
                MessageBox.Show("Please type nicknames of all players!");
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

        }
    }
}

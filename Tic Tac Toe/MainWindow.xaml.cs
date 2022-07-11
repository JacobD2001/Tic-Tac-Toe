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

namespace Tic_Tac_Toe
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


        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new PlayersNamesWindow().ShowDialog();

        }

        Logic logic = new Logic();

        private void btnSelectField_Click(object sender, RoutedEventArgs e)
        {
            var field = (Button)sender;
            //assuring you can't place X or O in already taken field
            if (field.Content.ToString() == "O" || field.Content.ToString() == "X")
            {
                MessageBox.Show("Choose different field");

            }
            else //else giving next move so switch from x -> o ,o -> x
            {
                field.Content = logic.CurrentPlayer;
                logic.NextPlayer();
            }

            if (logic.isWon())
            {
                MessageBox.Show("Congratulations {name of p1/p2} you won!");
            }
            


        }

        private void btnField1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnField2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnField3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnField4_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnField5_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnField6_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnField7_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnField8_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnField9_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}

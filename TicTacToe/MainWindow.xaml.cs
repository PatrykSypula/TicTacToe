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

namespace TicTacToe
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayer1Turn { get; set; }

        public int Counter { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        public void NewGame()
        {
            IsPlayer1Turn = false;
            Counter = 0;

            Button_0_0.Content = string.Empty;
            Button_1_0.Content = string.Empty;
            Button_2_0.Content = string.Empty;
            Button_0_1.Content = string.Empty;
            Button_1_1.Content = string.Empty;
            Button_2_1.Content = string.Empty;
            Button_0_2.Content = string.Empty;
            Button_1_2.Content = string.Empty;
            Button_2_2.Content = string.Empty;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button.Content.ToString() == string.Empty)
            {
                IsPlayer1Turn ^= true;
                Counter++;
                button.Content = IsPlayer1Turn ? "O" : "X";
            }
            else if (Counter == 9)
            {
                NewGame();
                return;
            }

            if (Counter > 9)
            {
                NewGame();
                return;
            }

            if (CheckIfPlayerWon())
            {
                Counter = 9;
            }
        }

        private bool CheckIfPlayerWon()
        {
            if (Button_0_0.Content.ToString() != string.Empty &&
                Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)//Row 0
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                return true;
            }

            if (Button_1_0.Content.ToString() != string.Empty &&
                Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)//Row 1
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                return true;
            }

            if (Button_2_0.Content.ToString() != string.Empty &&
                Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)//Row 2
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }

            if (Button_0_0.Content.ToString() != string.Empty &&
                Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)//Column 0
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }

            if (Button_0_1.Content.ToString() != string.Empty &&
                Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)//Column 1
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                return true;
            }

            if (Button_0_2.Content.ToString() != string.Empty &&
                Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)//Column 2
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }

            if (Button_0_0.Content.ToString() != string.Empty &&
                Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)//Diagonal 1
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }

            if (Button_0_2.Content.ToString() != string.Empty &&
                Button_0_2.Content == Button_1_1.Content && Button_1_1.Content == Button_2_0.Content)//Diagonal 2
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }

            return false;
        }
    }
}

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

namespace Amoba
{

    public partial class wndSettings : Window
    {
        #region SETTINGS
        string player1 = ""; // 1. játékos neve
        string player2 = ""; // 2. játékos neve
        int computer = 0; // ha 1, akkor pc játszik, ha 0, akkor nem ... ezt adja át a MainWindow ablaknak
        #endregion 

        public wndSettings()
        {
            InitializeComponent();
        }

        private void checked_cbComputer(object sender, RoutedEventArgs e)
        {
            if (cbComputer.IsChecked == true) // Ha be van jelölve, akkor...
            {
                tbPlayer2.Text = "BOT"; // beállítja a 2. játékos nevét BOT-ra
                tbPlayer2.IsEnabled = false; // beállítja, hogy ne lehessen beleírni
                computer = 1; // a computer értékét 1-re állítja
            }

            if (cbComputer.IsChecked == false) // Ha nincs bejelölve, akkor...
            {
                tbPlayer2.Text = ""; // beállítja a 2. játékos nevét üresre
                tbPlayer2.IsEnabled = true; // beállítja, hogy lehessen bele írni
                computer = 0; // a computer értékét 0-ra állítja
            }

        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            wndMenu wndMenu = new wndMenu();
            this.Hide(); //bezárja ezt az ablakot.. vagyis eltünteti
            wndMenu.ShowDialog(); // wndSettings ablak megnyitása
        }

        private void click_Start(object sender, RoutedEventArgs e)
        {
            adatokBetoltese(); // meghivja az adatokBetoltese függvényt 
            MainWindow mainWindow = new MainWindow(player1, player2, computer); //paraméterben átadja 2 nevet és a computer változót
            this.Hide(); //bezárja ezt az ablakot.. vagyis eltünteti
            mainWindow.ShowDialog(); // mainWindow ablak megnyitása
        }

        private void adatokBetoltese()
        {
            player1 = tbPlayer1.Text; // az 1. játékos nevét betölti a player1 változóba
            player2 = tbPlayer2.Text; // az 2. játékos nevét betölti a player2 változóba

        }


    }
}

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
    /// <summary>
    /// Interaction logic for wndSettings.xaml
    /// </summary>
    public partial class wndSettings : Window
    {
        #region SETTINGS
        string player1 = "";
        string player2 = "";
        bool computer = false;
        #endregion // a beállítás változói

        public wndSettings()
        {
            InitializeComponent();
        }

        private void click_Back(object sender, RoutedEventArgs e)
        {
            wndMenu wndMenu = new wndMenu();
            this.Hide(); //bezárja ezt az ablakot.. vagyis eltünteti
            wndMenu.ShowDialog(); // wndSettings ablak megnyitása
        }

        private void click_Start(object sender, RoutedEventArgs e)
        {
            adatokBetoltese();
            MainWindow mainWindow = new MainWindow(player1, player2);
            this.Hide(); //bezárja ezt az ablakot.. vagyis eltünteti
            mainWindow.ShowDialog(); // mainWindow ablak megnyitása
        }

        private void adatokBetoltese()
        {
            player1 = tbPlayer1.Text;
            player2 = tbPlayer2.Text;
            if (rbComputer.IsChecked == true)
                computer = true;
            else
                computer = false;
        }
    }
}

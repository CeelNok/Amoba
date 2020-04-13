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

namespace Amoba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region LEPESEK
        bool turn = true; //ez a változó fogja figyelni, hogy éppen melyik játékos fog következni.
        int turnCount = 0; //ez a változó fogja számolni a lépéseket.
        #endregion

        #region JATEKOSOK
        string player1;
        string player2;
        bool computer;
        #endregion

        public MainWindow(string p1name, string p2name)
        {
            whoStart(p1name, p2name); // a függvény eldönti, hogy melyik játékos kezd
            InitializeComponent();
            lbCurrently.Content = player2;
        }

        private void miUjjatek_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miEredmenyek_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miKilep_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender; //Button változó
            if (turn)
            {
                lbCurrently.Content = player1;
                btn.Content = "X"; // ha turn igaz, akkor az X következik
            }
            else
            {
                lbCurrently.Content = player2;
                btn.Content = "O"; // ha hamis, akkor az O következik
            }
            turn = !turn; 
            btn.IsEnabled = false;
            
        }

        private void miVissza_Click(object sender, RoutedEventArgs e)
        {
            wndSettings wndSettings = new wndSettings();
            this.Hide(); //bezárja ezt az ablakot.. vagyis eltünteti
            wndSettings.ShowDialog(); // wndSettings ablak megnyitása
        }

        private void whoStart(string p1, string p2)
        {
            Random r = new Random();
            int rand  = r.Next(2);
            if (rand == 0)
            {
                player1 = p1;
                player2 = p2;
            }       
            if (rand == 1)
            {
                player1 = p2;
                player2 = p1;
            }

        }

    }
}

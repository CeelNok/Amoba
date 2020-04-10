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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void miUjjatek_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miEredmenyek_Click(object sender, RoutedEventArgs e)
        {

        }

        private void miKilep_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void button_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender; //Button változó

            if (turn) 
                btn.Content = "X"; // ha igaz, akkor az X következik
            else
                btn.Content = "O"; // ha hamis, akkor az O következik
            turn = !turn;
            btn.IsEnabled = false;
            
        }
    }
}

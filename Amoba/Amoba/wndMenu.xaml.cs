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
    /// Interaction logic for wndMenu.xaml
    /// </summary>
    public partial class wndMenu : Window
    {
        public wndMenu()
        {
            InitializeComponent();
        }

        private void click_UjJatek(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide(); //bezárja ezt az ablakot.. vagyis eltünteti
            mainWindow.ShowDialog(); // mainWindow ablak megnyitása
        }

        private void click_Eredmenyek(object sender, RoutedEventArgs e)
        {

        }

        private void click_Kilep(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // bezátja a programot
        }
    }
}

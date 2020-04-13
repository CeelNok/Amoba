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
    }
}

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
using databaseAmoba_DAL;

namespace Amoba
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private cnDatabaseAmoba cnDatabaseAmoba;
        public Window1()
        {
            InitializeComponent();
            cnDatabaseAmoba = new cnDatabaseAmoba();
            var er = (from x in cnDatabaseAmoba.enGames select new { x.p1Name, x.p2Name }).ToList();
            dgAdatracs.ItemsSource = er;
        }


        private void btnKiir_Click_1(object sender, RoutedEventArgs e)
        {
            cnDatabaseAmoba.SaveChanges();
            var er = (from x in cnDatabaseAmoba.enGames select new { x.p1Name, x.p2Name }).ToList();
            dgAdatracs.ItemsSource = er;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AplikasiSepatu.UI
{
    /// <summary>
    /// Interaction logic for Pemesanan.xaml
    /// </summary>
    public partial class Pemesanan : Window
    {
        public Pemesanan()
        {
            InitializeComponent();
        }

        private void OnClickBack(object sender, MouseButtonEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void OnClickPeta(object sender, MouseButtonEventArgs e)
        {
            Maps1 maps = new Maps1();
            maps.Show();
            this.Close();
        }

        private void OnClickCheckOut(object sender, MouseButtonEventArgs e)
        {
            CheckOut check = new CheckOut();
            check.Show();
            this.Close();
        }
    }
}

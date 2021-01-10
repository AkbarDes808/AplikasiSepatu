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
    /// Interaction logic for Maps1.xaml
    /// </summary>
    public partial class Maps1 : Window
    {
        public Maps1()
        {
            InitializeComponent();
        }

        private void OnClckBack(object sender, MouseButtonEventArgs e)
        {
            Pemesanan home = new Pemesanan();
            home.Show();
            this.Close();
        }

        private void OnClickKonfirmasi(object sender, MouseButtonEventArgs e)
        {
            Maps2 pemesanan = new Maps2();
            pemesanan.Show();
            this.Close();
        }
    }
}

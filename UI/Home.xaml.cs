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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void OnPesanClick(object sender, MouseButtonEventArgs e)
        {
            Pesan pesan = new Pesan();
            pesan.Show();
            this.Close();
        }

        private void OnClickPemesanan(object sender, MouseButtonEventArgs e)
        {
            Maps2 map = new Maps2();
            map.Show();
            this.Close();
        }

        private void OnRiwatClicked(object sender, MouseButtonEventArgs e)
        {
            Riwayat riwayat = new Riwayat();
            riwayat.Show();
            this.Close();
        }
    }
}

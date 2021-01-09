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
    /// Interaction logic for CheckOut.xaml
    /// </summary>
    public partial class CheckOut : Window
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void OnClickBackButton(object sender, MouseButtonEventArgs e)
        {
            Pemesanan pemesanan = new Pemesanan();
            pemesanan.Show();
            this.Close();
        }

        private void OnClickPesan(object sender, MouseButtonEventArgs e)
        {
            Selesai selesai = new Selesai();
            selesai.Show();
            this.Close();
        }
    }
}

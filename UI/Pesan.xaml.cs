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
    /// Interaction logic for Pesan.xaml
    /// </summary>
    public partial class Pesan : Window
    {
        public Pesan()
        {
            InitializeComponent();
        }

        private void OnPesanClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void OnBackClick(object sender, MouseButtonEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void OnClickButton(object sender, MouseButtonEventArgs e)
        {
            Notifikasi notif = new Notifikasi();
            notif.Show();
            this.Close();
        }
    }
}

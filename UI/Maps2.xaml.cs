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
    /// Interaction logic for Maps2.xaml
    /// </summary>
    public partial class Maps2 : Window
    {
        public Maps2()
        {
            InitializeComponent();
        }

        private void OnClickMap(object sender, MouseButtonEventArgs e)
        {
            Pemesanan map = new Pemesanan();
            map.Show();
            this.Close();
        }

        private void OnClickBack(object sender, MouseButtonEventArgs e)
        {
            Maps1 home = new Maps1();
            home.Show();
            this.Close();
        }
    }
}

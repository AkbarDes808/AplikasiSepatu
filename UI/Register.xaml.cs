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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void OnClickSignUp(object sender, RoutedEventArgs e)
        {
            SignIn window = new SignIn();
            window.Show();
            this.Close();
        }

        private string Nama_TextChanged(object sender, TextChangedEventArgs e)
        {
            var data = Convert.ToInt32(Nama.Text);
            var tampil = data;
            return Convert.ToString(data);
        }
    }
}

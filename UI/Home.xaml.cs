using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_Sepatu;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Username FROM register", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Nama.Content = dr["Username"].ToString();

            }
            else
            {
                Nama.Content = "Guest".ToString();
            }
            con.Close();
        }
    

        private void OnPesanClick(object sender, MouseButtonEventArgs e)
        {
            Pesan pesan = new Pesan();
            pesan.Show();
            this.Close();
        }

        private void OnClickPemesanan(object sender, MouseButtonEventArgs e)
        {
            Pemesanan map = new Pemesanan();
            map.Show();
            this.Close();
        }

        private void OnRiwatClicked(object sender, MouseButtonEventArgs e)
        {
            Riwayat riwayat = new Riwayat();
            riwayat.Show();
            this.Close();
        }

        private void OnClickLogout(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_Sepatu;Integrated Security=True");

            string sqlStatement = "DELETE FROM register";

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, connection);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            finally
            {
                connection.Close();
            }

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}

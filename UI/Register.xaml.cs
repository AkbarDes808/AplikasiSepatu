using System;
using System.Collections.Generic;
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ("Data Source=LAPTOP-E01TKF81;Initial Catalog=db_Sepatu;Integrated Security=True");
            con.Open();
            String st = "INSERT INTO register(Username, Email) values (@Username, @Email)";
            SqlCommand cmd = new SqlCommand(st, con);
            cmd.Parameters.AddWithValue("@Username", Nama.Text);
            cmd.Parameters.AddWithValue("@Email", Email.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            SignIn register = new SignIn();
            register.Show();
            this.Close();
        }
        private void Nama_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}

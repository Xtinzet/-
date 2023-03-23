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
using System.Data.SqlClient;

namespace Светодиодные_лампы
{
    /// <summary>
    /// Логика взаимодействия для Авторизация.xaml
    /// </summary>
    public partial class Авторизация : Window
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void Reg(object sender, RoutedEventArgs e)
        {
            Регистрация р = new Регистрация();
            р.Show();
            Close();
        }

        private void Auth(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = FERKIE; Initial Catalog = all; Integrated Security = SSPI");
            SqlCommand com = new SqlCommand("SELECT * FROM  [tbUser] Where Login=@Login AND Password=@Password", con);
            con.Open();

            com.Parameters.AddWithValue("@Login", LoginBox.Text);
            com.Parameters.AddWithValue("@Password", Password.Password);
            SqlDataReader i = com.ExecuteReader();
            if (i.Read())
            {
                MessageBox.Show("Успешная авторизация");
                Меню Меню = new Меню();
                Меню.Show();
                Hide();
            }


            else
                MessageBox.Show("пошел вон");

        }

        private void checkPass_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;

            if (checkPass.IsChecked.Value)
            {
                Password1.Text = Password.Password;
                Password1.Visibility = Visibility.Visible;
                Password.Visibility = Visibility.Hidden;
            }


            else

            {
                Password.Password = Password1.Text;
                Password1.Visibility = Visibility.Hidden;
                Password.Visibility = Visibility.Visible;

            }

        }
    }
}
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
    /// Логика взаимодействия для Регистрация.xaml
    /// </summary>
    public partial class Регистрация : Window
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Auth(object sender, RoutedEventArgs e)
        {
            Авторизация ав = new Авторизация();
            ав.Show();
            Close();
        }

        private void CheckUs_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Пользовательское_соглашение пользовательское_Соглашение = new Пользовательское_соглашение();
            пользовательское_Соглашение.Show();

        }

        private void Register(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = FERKIE; Initial Catalog = all; Integrated Security = SSPI");
            string query = "Insert into [tbUser] (Login,Password,Number_Phone,Email,Name,Family) values (@Login,@Password,@Number_Phone,@Email,@Name,@Family)";

            SqlCommand com = new SqlCommand(query, con);
            con.Open();

            com.Parameters.AddWithValue("@Login", Login.Text);
            com.Parameters.AddWithValue("@Password", Password.Password);
            com.Parameters.AddWithValue("@Number_Phone", Number_Phone.Text);
            com.Parameters.AddWithValue("@Email", Email.Text);
            com.Parameters.AddWithValue("@Name", Name.Text);
            com.Parameters.AddWithValue("@Family", Surnname.Text);



            int a = com.ExecuteNonQuery();

            if (a == 1)
            {
                MessageBox.Show("Успешная регистрация");
            }
            else MessageBox.Show("пошел вон");

            Авторизация auth = new Авторизация();
            auth.Show();
            Hide();

        }
    }
}

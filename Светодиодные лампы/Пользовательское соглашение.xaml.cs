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

namespace Светодиодные_лампы
{
    /// <summary>
    /// Логика взаимодействия для Пользовательское_соглашение.xaml
    /// </summary>
    public partial class Пользовательское_соглашение : Window
    {
        public Пользовательское_соглашение()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Регистрация р = new Регистрация();
            р.Show();
            Close();
        }
    }
}

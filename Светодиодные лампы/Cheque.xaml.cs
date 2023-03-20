using KovriMagaz.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KovriMagaz.Views
{
    /// <summary>
    /// Логика взаимодействия для Cheque.xaml
    /// </summary>
    public partial class Cheque : Page
    {
        DataBaseConn database = new DataBaseConn();
        public Cheque()
        {
            InitializeComponent();
            DataOutputInLabels();

        }
        private void DataOutputInLabels()
        {
            string ID = $"SELECT * FROM Cheque WHERE id = '{LocalData.ID}'";
            SqlCommand IDUser = new SqlCommand(ID, database.getConnection());
            database.openConnection();
            SqlDataReader reader = IDUser.ExecuteReader();
            while (reader.Read())
            {
                dataLabel.Content = reader[1].ToString();
                SummaLabel.Content = reader[2].ToString() + "руб";
                SummaNdcLabel.Content = reader[3].ToString() + "руб";
                NChechLabel.Content = reader[4].ToString();
                NSmenaLabel.Content = reader[5].ToString();
                MestoRaschLabel.Content = reader[6].ToString();
                AdressLabel.Content = reader[7].ToString();
                SaitFnoLabel.Content = reader[8].ToString();
                OfdLabel.Content = reader[9].ToString();
                ZnKktLabel.Content = reader[10].ToString();
                ChoLabel.Content = reader[11].ToString();
                InnLabel.Content = reader[12].ToString();
                RnKktLabel.Content = reader[13].ToString();
                FdNLabel.Content = reader[14].ToString();
                FpLabel.Content = reader[15].ToString();
                FIOLabel.Text = reader[16].ToString();
                NamesTovars.Text = reader[17].ToString();
                FnNLabel.Content = reader[19].ToString();
            }
            reader.Close();

            //FIOLabel.Text = CurUser.Name + " " + CurUser.Surname + " " + CurUser.Patronymic;
            //dataLabel.Content = DateTime.Now.ToString("yyyy/MM/dd hh:mm");
            ////dataLabel.Content = DateTime.Now.ToString("hh:mm:ss");
            //SummaLabel.Content = LocalData.SUM + "руб";
            //SummaNdcLabel.Content = LocalData.SUM + "руб";
            //NChechLabel.Content = LocalData.NChech;
            //NSmenaLabel.Content = "00243";
            //MestoRaschLabel.Content = "интернет-магазин";
            //AdressLabel.Content = "Россия г.Волоколамск ул.Энтузиастов д.36 кв.44";
            //SaitFnoLabel.Content = "nalog.ru";
            //OfdLabel.Content = "ООО Эвотор ОФД";
            //ZnKktLabel.Content = "00106308044145";
            //ChoLabel.Content = "УСН доход-расход";
            //InnLabel.Content = "5009098871";
            //RnKktLabel.Content = "0001209391030460";
            //FnNLabel.Content = "9283440300073442";
            //FdNLabel.Content = "0000030212";
            //FpLabel.Content = "0926492810";
            //NamesTovars.Text = "";


        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog print = new PrintDialog();
            print.ShowDialog();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FR.Navigate(new Uri("Views/Complete.xaml", UriKind.Relative));
        }
    }
}

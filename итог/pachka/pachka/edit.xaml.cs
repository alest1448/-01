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
using MySql.Data.MySqlClient;

namespace pachka
{
    /// <summary>
    /// Логика взаимодействия для edit.xaml
    /// </summary>
    public partial class edit : Window
    {
        public edit()
        {
            InitializeComponent();
        }

        private void tbBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            this.Close();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            string connstring = "server=localhost; user id = root; password=i_nAMELESS_wRITER_2004; database = pachka";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connstring;
            conn.Open();
            // запрос возвращающий набор данных из базы данных 
            string sql = $"UPDATE `pachka`.`material` SET `name` = '{tbName.Text}', `type` = '{ tbType.Text}', `image` =' { tbImage.Text}', `price` = '{ tbPrice.Text}', `sklad` = '{ tbSklad.Text}', `max` = '{ tbMax.Text}', `kolvo` = '{ tbKolvo.Text}', `ed` = '{ tbEd.Text}'    WHERE `idMaterial` = '{tbID.Text}'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно изменены!");
        }
    }
}

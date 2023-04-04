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

namespace AutoAll
{
    /// <summary>
    /// Логика взаимодействия для edit.xaml
    /// </summary>
    public partial class edit : Window
    {
        public edit()
        {
            InitializeComponent();
            dt = new DataBaseClass();

            cmdGender.ItemsSource = dt.ReadGender();
            cmbStatus.ItemsSource = dt.ReadStatus();
        }
        DataBaseClass dt;
        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            string connstring = "server=localhost; user id = root; password=i_nAMELESS_wRITER_2004; database = autoall";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connstring;
            conn.Open();
            // запрос возвращающий набор данных из базы данных 
            string sql = $"UPDATE `autoall`.`clients` SET `nameClient` = '{tbName.Text}', `Birthday` = '{tbBirthaday.Text}', `Gender` = '{cmdGender.Text}', `Email` = '{tbEmail.Text}', `Phone` = '{tbPhone.Text}', `StatusClient` = '{cmbStatus.Text}' WHERE `idClient` = '{tbID.Text}';";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно изменены!");

        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            menu window1 = new menu();
            window1.Show();
            this.Close();
        }
    }
}

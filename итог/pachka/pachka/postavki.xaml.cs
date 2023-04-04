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
using System.Data;

namespace pachka
{
    /// <summary>
    /// Логика взаимодействия для postavki.xaml
    /// </summary>
    public partial class postavki : Window
    {
        public postavki()
        {
            InitializeComponent();
            dt = new DataBaseClass();
            FillGrid();

        }
        DataBaseClass dt;

        private void btEdit_Click(object sender, RoutedEventArgs e)
        {
            string connstring = "server=localhost; user id = root; password=i_nAMELESS_wRITER_2004; database = pachka";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connstring;
            conn.Open();
            // запрос возвращающий набор данных из базы данных 
            string sql = $"UPDATE `pachka`.`postavki` SET `nameClient` = '{tbMaterial.Text}',  `postavshik` = '{ tbPostavki.Text}'   WHERE `idPostavka` = '{tbID1.Text}'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные успешно изменены!");
     
        }
        public void FillGrid()
        {
            string MyConString = "server=localhost; user id = root; password=i_nAMELESS_wRITER_2004; database = pachka";

            string sql = "SELECT * from postavki";

            using (MySqlConnection connection = new MySqlConnection(MyConString))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    dgClients.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dt.AddPOstavki(tbMaterial.Text, tbPostavki.Text) > 0)
            {
                MessageBox.Show(" данные добавлены");
                 postavki newWindow = new postavki();
                Application.Current.MainWindow = newWindow;
                newWindow.Show();
                this.Close();


            }
            else
            {
                MessageBox.Show("No");

            }
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить клиента?", "Предупреждение", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {


                string connstring = "server=localhost; user id = root; password=i_nAMELESS_wRITER_2004; database = pachka";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                string sql = $"Delete from postavki where idPostavka = {tbID.Text}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                postavki newWindow = new postavki();
                Application.Current.MainWindow = newWindow;
                newWindow.Show();
                this.Close();




            }
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            this.Close();
        }
    }
}

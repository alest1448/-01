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

namespace AutoAll
{
    /// <summary>
    /// Логика взаимодействия для menu.xaml
    /// </summary>
    public partial class menu : Window
    {
        public menu()
        {
            InitializeComponent();
            FillGrid();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            registerClient window1 = new registerClient();
            window1.Show();
            this.Close();
        }
        public void FillGrid()
        {
            string MyConString = "server=localhost; user id = root; password=i_nAMELESS_wRITER_2004; database = autoall";

            string sql = "SELECT * from clients";

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

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить клиента?", "Предупреждение", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                

                string connstring = "server=localhost; user id = root; password=i_nAMELESS_wRITER_2004; database = autoall";
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                // запрос возвращающий набор данных из базы данных 
                string sql = $"Delete from clients where idClient = {tbID.Text}";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                menu newWindow = new menu();
                Application.Current.MainWindow = newWindow;
                newWindow.Show();
                this.Close();


            }
            else
            {

            }
        }

        private void btEdit_Click(object sender, RoutedEventArgs e)
        {
            edit window1 = new edit();
            window1.Show();
            this.Close();
        }
    }
}

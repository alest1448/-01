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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;


namespace AutoAll
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dt = new DataBaseClass();

        }
        DataBaseClass dt;

        private void bhRegister_Click(object sender, RoutedEventArgs e)
        {
            registrationUser window1 = new registrationUser();
            window1.Show();
            this.Close();
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {

            string connstring = "server=localhost; user id = root; password=i_nAMELESS_wRITER_2004; database = autoall";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = connstring;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from users where login='" + tbLogin.Text + "'  and password='" + passwordBox.Password + "'", conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet.Tables[0].Rows.Count > 0)
            {
                menu window1 = new menu();
                window1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверно введен логин или пароль!");
                tbLogin.Text = "";
                passwordBox.Password = "";

            }
            conn.Close();
        }



    }
    }


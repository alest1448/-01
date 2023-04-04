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
    /// Логика взаимодействия для registrationUser.xaml
    /// </summary>
    public partial class registrationUser : Window
    {
        public registrationUser()
        {
            InitializeComponent();

            dt = new DataBaseClass();
        }
        DataBaseClass dt;
        private void tbLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            this.Close();
        }

        private void btRegister_Click(object sender, RoutedEventArgs e)
        {
            if(PasswordBox1.Password== PasswordBox2.Password)
            {
                if (dt.AddUser(tbLogin.Text, PasswordBox1.Password) > 0)
                {
                    MessageBox.Show("Вы успешно зарегистрировались!");
                    MainWindow window1 = new MainWindow();
                    window1.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No");

                }
            }
        }
    }
}

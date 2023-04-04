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

namespace AutoAll
{
    /// <summary>
    /// Логика взаимодействия для registerClient.xaml
    /// </summary>
    public partial class registerClient : Window
    {
        public registerClient()
        {
            InitializeComponent();
            dt = new DataBaseClass();

            cmdGender.ItemsSource = dt.ReadGender();
            cmbStatus.ItemsSource = dt.ReadStatus();
            string today = DateTime.Today.ToString("dd.MM.yy");
            tbDate.Text = today;


        }
        DataBaseClass dt;

        private void tbBack_Click(object sender, RoutedEventArgs e)
        {
            menu window1 = new menu();
            window1.Show();
            this.Close();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dt.AddClient(tbName.Text, tbBirthaday.Text, cmdGender.Text, tbDate.Text, tbEmail.Text, tbPhone.Text, cmbStatus.Text) > 0)
            {
                MessageBox.Show("Клиент успешно зарегистрирован!");
                tbBirthaday.Text = "";
                tbEmail.Text = "";
                tbName.Text = "";
                tbPhone.Text = "";
              

            }
            else
            {
                MessageBox.Show("No");

            }
        }
    }
}

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
    /// Логика взаимодействия для add.xaml
    /// </summary>
    public partial class add : Window
    {
        public add()
        {
            InitializeComponent();
            dt = new DataBaseClass();

        }
        DataBaseClass dt;

        private void tbBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            this.Close();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dt.AddMat(tbName.Text, tbName.Text, tbType.Text, tbImage.Text, tbPrice.Text, tbSklad.Text, tbMax.Text, tbEd.Text) > 0)
            {
                MessageBox.Show("Материал добавлен");
                

                
            }
            else
            {
                MessageBox.Show("No");

            }
        }
    }
}

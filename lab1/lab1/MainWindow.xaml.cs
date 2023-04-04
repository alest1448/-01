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
using System.Windows.Media.Animation;

namespace lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            //Укажем с какой позиции стартует анимация
            animation.From = 50;
            animation.To = 300;
            //Укажем время за которое пройдет анимация
            animation.Duration = TimeSpan.FromSeconds(0.5);
            //Сглаживание анимации, когда анимация будет подходить к концу, то замедляется её воспроизведение
            animation.EasingFunction = new QuadraticEase();
            //Укажем объект к которому присовоим анимацию
            Grl.BeginAnimation(HeightProperty, animation);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 50;
            animation.To = 300;
            animation.Duration = TimeSpan.FromSeconds(0.5);
            animation.EasingFunction = new QuadraticEase();
            Grl2.BeginAnimation(HeightProperty, animation);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 50;
            animation.To = 300;
            animation.Duration = TimeSpan.FromSeconds(0.5);
            animation.EasingFunction = new QuadraticEase();
            Grl3.BeginAnimation(WidthProperty, animation);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TranslateTransform trans = new TranslateTransform();
            //Определяем элемент, который будет видоизменяться 
            Grl4.RenderTransform = trans;
            //Указываем в аргументах откуда и куда будет двигаться объект, а также время анимации
            DoubleAnimation animationX = new DoubleAnimation(0, 50, TimeSpan.FromSeconds(1));
            trans.BeginAnimation(TranslateTransform.XProperty, animationX);
            DoubleAnimation animationY = new DoubleAnimation(0, 150, TimeSpan.FromSeconds(1));
            trans.BeginAnimation(TranslateTransform.YProperty, animationY);
        }
    }
}

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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window12 = new MainWindow();
            this.Close();
            window12.Show();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DisplayImageForm.Source = new BitmapImage(new Uri("C:/Users/Ваня/Downloads/images123321/rem-rezero.gif"));
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            DisplayImageForm.Source = new BitmapImage(new Uri("C:/Users/Ваня/Downloads/images123321/71616413.jpeg"));

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            DisplayImageForm.Source = new BitmapImage(new Uri("C:/Users/Ваня/Downloads/images123321/images.jpeg"));
        }
    }
}

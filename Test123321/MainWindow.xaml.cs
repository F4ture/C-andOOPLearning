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

namespace Test123321
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

        private void Ready_Click(object sender, RoutedEventArgs e)
        {
            if (rButton13.IsChecked == true || rButton14.IsChecked == true || rButton15.IsChecked == true || rButton16.IsChecked == true)
            {
                if (rButton8.IsChecked == true && rButton9.IsChecked == true && rButton18.IsChecked == true)
                {
                    HaHaHa.Text = "Ну а всё таки что насчёт 100 баллов?";
                    Answer.Text = "Победа, а теперь посмотри на 3ий вопрос";
                }
                else
                {
                    HaHaHa.Text = "Ну а всё таки что насчёт 100 баллов?";
                    Answer.Text = "Проигрышь, а теперь посмотри на 3ий вопрос";
                }
            }
            else
            {
                Answer.Text = "Ответь на важное";
            }
        }
    }
}

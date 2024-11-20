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
using static System.Net.Mime.MediaTypeNames;

namespace Test123321
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

        private void Ready_Click(object sender, RoutedEventArgs e)
        {
                if (rButton13.IsChecked == true || rButton14.IsChecked == true || rButton15.IsChecked == true || rButton16.IsChecked == true)
                {
                    if (rButton5.IsChecked == true || rButton6.IsChecked == true || rButton9.IsChecked == true || rButton11.IsChecked == true || rButton20.IsChecked == true)
                    {
                        Answer.Text = "Молодец всё верно";
                    }
                    else
                    {
                        Answer.Text = "Проигрышь";
                    }
                }
                else
                {
                    Answer.Text = "Ответь на важное";
                }
        }
    }
}

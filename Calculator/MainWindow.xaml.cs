using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup.Localizer;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp1=0;
        double temp2=0;

        int action;
        int countaction = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += ((Button)sender).Content;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            temp1=0;
            temp2=0;
            action = 0;
        }

        private void ButtonCount_Click(object sender, RoutedEventArgs e)
        {
            switch (countaction)
            {
                case 0:

                    break;
                case 1:
                    TextBox1.Text = Convert.ToString(double.Parse(TextBox1.Text) + temp2);
                    countaction = 1;
                    break;
                case 2:
                    TextBox1.Text = Convert.ToString(double.Parse(TextBox1.Text) - temp2);
                    countaction = 2;

                    break;
                case 3:
                    TextBox1.Text = Convert.ToString(double.Parse(TextBox1.Text) * temp2);
                    countaction = 3;

                    break;
                case 4:
                    if (temp2 == 0)
                    {
                        TextBox1.Text = Convert.ToString(0);
                        break;
                    }
                    TextBox1.Text = Convert.ToString(double.Parse(TextBox1.Text) / temp2);
                    countaction = 4;
                    break;


            }
            switch (action)
            {
                case 0:
                    break;
                case 1:

                    temp2 = double.Parse(TextBox1.Text);
                    TextBox1.Text = Convert.ToString(temp1 + temp2);
                    countaction = 1;
                    break;
                case 2:
                    temp2 = double.Parse(TextBox1.Text);
                    TextBox1.Text = Convert.ToString(temp1 - temp2);
                    countaction = 2;

                    break;
                case 3:
                    temp2 = double.Parse(TextBox1.Text);
                    TextBox1.Text = Convert.ToString(temp1 * temp2);
                    countaction = 3;

                    break;
                case 4:
                    temp2 = double.Parse(TextBox1.Text);
                    if (temp2 == 0)
                    {
                        TextBox1.Text = Convert.ToString(0);
                        break;
                    }
                    TextBox1.Text = Convert.ToString(temp1 / temp2);
                    countaction = 4;
                    break;

            }
            action = 0;
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            switch (action)
            {
                case 0:
                    temp1 = double.Parse(TextBox1.Text);

                    break;
                case 1:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 + temp2;
                    break;
                case 2:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 - temp2;
                    break;
                case 3:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 * temp2;
                    break;
                case 4:
                    temp2 = double.Parse(TextBox1.Text);
                    if (temp2 == 0)
                    {
                        temp1 = 0;
                        break;
                    }
                    temp1 = temp1 / temp2;
                    break;
            }
            action = 3;
            countaction = 0;
            TextBox1.Text = "";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            switch (action)
            {
                case 0:
                    temp1 = double.Parse(TextBox1.Text);

                    break;
                case 1:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 + temp2;
                    break;
                case 2:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 - temp2;
                    break;
                case 3:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 * temp2;
                    break;
                case 4:
                    temp2 = double.Parse(TextBox1.Text);
                    if (temp2 == 0)
                    {
                        temp1 = 0;
                        break;
                    }
                    temp1 = temp1 / temp2;
                    break;
            }
            action = 2;
            countaction = 0;
            TextBox1.Text = "";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {

            switch (action)
            {
                case 0:
                    temp1 = double.Parse(TextBox1.Text);

                    break;
                case 1:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 + temp2;
                    break;
                case 2:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 - temp2;
                    break;
                case 3:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 * temp2;
                    break;
                case 4:
                    temp2 = double.Parse(TextBox1.Text);
                    if (temp2 == 0)
                    {
                        temp1 = 0;
                        break;
                    }
                    temp1 = temp1 / temp2;
                    break;
            }
            TextBox1.Text = "";
            countaction = 0;
            action = 1;
        }

        private void Button_Dot(object sender, RoutedEventArgs e)
        {
            if (!TextBox1.Text.Contains(","))
            {
                TextBox1.Text = TextBox1.Text + ",";
            }
            else
            {

            }
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            switch (action)
            {
                case 0:
                    temp1 = double.Parse(TextBox1.Text);
                    break;
                case 1:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 + temp2;
                    break;
                case 2:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 - temp2;
                    break;
                case 3:
                    temp2 = double.Parse(TextBox1.Text);
                    temp1 = temp1 * temp2;
                    break;
                case 4:
                    temp2 = double.Parse(TextBox1.Text);
                    if (temp2 == 0)
                    {
                        temp1 = 0;
                        break;
                    }
                    temp1 = temp1 / temp2;
                    break;
            }
            action = 4;
            countaction = 0;
            TextBox1.Text = "";
        }

        private void ButtonMinusAdd(object sender, RoutedEventArgs e)
        {
            if (!TextBox1.Text.Contains("-") & TextBox1.Text=="")
            {
                TextBox1.Text = TextBox1.Text + "-";
            }
            else
            {
                
            }
        }
    }
}

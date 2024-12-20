﻿using System;
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

namespace WpfApp2
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
            Window1 window = new Window1();
            this.Close();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int value1 = rnd.Next(0, 255);
            int value2 = rnd.Next(0, 255);
            int value3 = rnd.Next(0, 255);
            MainWindow window = new MainWindow();
            this.Background = new SolidColorBrush(Color.FromRgb(Convert.ToByte(value1), Convert.ToByte(value2), Convert.ToByte(value3)));
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Window2 window3 = new Window2();
            this.Close();
            window3.Show();
        }
    }
}

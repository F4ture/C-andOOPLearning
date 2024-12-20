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

namespace TreeView
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
        private void TreeViewItem_OnSelected(object sender, RoutedEventArgs a)
        {
            TreeViewItem treeViewItem = (TreeViewItem)sender;
            MessageBox.Show($"Ты нажал на язык программирования: {treeViewItem.Header.ToString()}", "Выбери что накодить", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

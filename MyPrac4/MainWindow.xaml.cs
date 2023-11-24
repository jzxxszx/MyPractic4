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

namespace MyPrac4
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

        private void FirstPageButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page1());
        }

        private void TwoPageButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page2());
        }

        private void ThreePageButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page3());
        }

        private void Dop1PageButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new DopPage1());
        }

        private void Dop2PageButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new DopPage2());
        }

        private void Dop3PageButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new DopPage3());
        }

        private void SixPageButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page6());
        }

        private void FivePageButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page5());
        }

        private void FourPageButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(new Page4());
        }
    }
}

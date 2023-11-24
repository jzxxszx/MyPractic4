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
using static System.Math;

namespace MyPrac4
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!double.TryParse(numbokrbox.Text, out double N))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(elementbox.Text, out double L))
            {
                MessageBox.Show("Введите число!");
            }
            double x = 0, r = 0, d = 0, l = 0, s = 0;

            switch (N)
            {
                case 1:
                    r = L;
                    d = 2 * r;
                    l = 2 * 3.14 * r;
                    s = 3.14 * Sqrt(r);
                    Answer.Text += $"{d:f2}\n{l:f2}\n{s:f2}\n";
                    break;
                case 2:
                    r = L / 2;
                    d = L;
                    l = 2 * 3.14 * r;
                    s = 3.14 * Sqrt(r);
                    Answer.Text += $"{d:f2}\n{l:f2}\n{s:f2}\n";
                    break;
                case 3:
                    r = L / 2 * 3.14;
                    d = 2 * r;
                    l = L;
                    s = 3.14 * Sqrt(r);
                    Answer.Text += $"{d:f2}\n{l:f2}\n{s:f2}\n";
                    break;
                case 4:
                    r = Sqrt(L / 3.14);
                    d = 2 * r;
                    l = 2 * 3.14 * r;
                    s = L;
                    Answer.Text += $"{d:f2}\n{l:f2}\n{s:f2}\n";
                    break;
                default:
                    Answer.Text += ("Ошибка!");
                    break;
            }

        }
    }
}

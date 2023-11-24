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

namespace MyPrac4
{
    /// <summary>
    /// Логика взаимодействия для DopPage1.xaml
    /// </summary>
    public partial class DopPage1 : Page
    {
        public DopPage1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(NumberX.Text, out int x) && 10 <= x && x <= 40)
            {
                MessageBox.Show("Введите число!");
            }

            if (x / 10 == 1)
            {
                switch (x)
                {
                    case 10: Answer.Text += "десять учебных заданий\n"; break;
                    case 11: Answer.Text += "одинадцать учебных заданий\n"; break;
                    case 12: Answer.Text += "двенадцать учебных заданий\n"; break;
                    case 13: Answer.Text += "тринадцать учебных заданий\n"; break;
                    case 14: Answer.Text += "четырнадцать учебных заданий\n"; break;
                    case 15: Answer.Text += "пятнадцать учебных заданий\n"; break;
                    case 16: Answer.Text += "шестнадцаь учебных заданий\n"; break;
                    case 17: Answer.Text += "семнадцать учебных заданияй\n"; break;
                    case 18: Answer.Text += "восемнадцать учебных заданий\n"; break;
                    case 19: Answer.Text += "девятнадцать учебных заданий\n"; break;
                }
            }
            else
            {
                switch (x / 10)
                {
                    case 2: Answer.Text += "двадцать"; break;
                    case 3: Answer.Text += "тридцать"; break;
                    case 4: Answer.Text += "сорок"; break;
                }
                switch (x % 10)
                {
                    case 1: Answer.Text += " одно учебное задание\n"; break;
                    case 2: Answer.Text += " два учебных задания\n"; break;
                    case 3: Answer.Text += " три учебных задания\n"; break;
                    case 4: Answer.Text += " четыре учебных задания\n"; break;
                    case 5: Answer.Text += " пять учебных заданий\n"; break;
                    case 6: Answer.Text += " шесть учебных заданий\n"; break;
                    case 7: Answer.Text += " семь учебных заданий\n"; break;
                    case 8: Answer.Text += " восемь учебных заданий\n"; break;
                    case 9: Answer.Text += " девять учебных заданий\n"; break;
                }
            }
        }
    }
}

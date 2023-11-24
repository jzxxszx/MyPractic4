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
    /// Логика взаимодействия для DopPage2.xaml
    /// </summary>
    public partial class DopPage2 : Page
    {
        public DopPage2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(NumberX.Text, out int x) && 100 <= x && x <= 999)
            {
                MessageBox.Show("Введите число!");
            }

            switch (x / 100)
            {
                case 1: Answer.Text += "сто"; break;
                case 2: Answer.Text += "двести"; break;
                case 3: Answer.Text += "триста"; break;
                case 4: Answer.Text += "четыреста"; break;
                case 5: Answer.Text += "пятьсот"; break;
                case 6: Answer.Text += "шестьсот"; break;
                case 7: Answer.Text += "семьсот"; break;
                case 8: Answer.Text += "восемьсот"; break;
                case 9: Answer.Text += "девятьсот"; break;
            }
            if (x % 100 / 10 == 1)
            {
                switch (x)
                {
                    case 10: Answer.Text += "десять"; break;
                    case 11: Answer.Text += "одинадцать"; break;
                    case 12: Answer.Text += "двенадцать"; break;
                    case 13: Answer.Text += "тринадцать"; break;
                    case 14: Answer.Text += "четырнадцать"; break;
                    case 15: Answer.Text += "пятнадцать"; break;
                    case 16: Answer.Text += "шестнадцаь"; break;
                    case 17: Answer.Text += "семнадцать"; break;
                    case 18: Answer.Text += "восемнадцать"; break;
                    case 19: Answer.Text += "девятнадцать"; break;
                }
            }
            else
            {
                switch (x % 100 / 10)
                {
                    case 2: Answer.Text += " двадцать"; break;
                    case 3: Answer.Text += " тридцать"; break;
                    case 4: Answer.Text += " сорок"; break;
                    case 5: Answer.Text += " пятьдесят"; break;
                    case 6: Answer.Text += " шестьдесят"; break;
                    case 7: Answer.Text += " семьдесят"; break;
                    case 8: Answer.Text += " восемьдесят"; break;
                    case 9: Answer.Text += " девяносто"; break;
                }
                switch (x % 10)
                {
                    case 1: Answer.Text += " один\n"; break;
                    case 2: Answer.Text += " два\n"; break;
                    case 3: Answer.Text += " три\n"; break;
                    case 4: Answer.Text += " четыре\n"; break;
                    case 5: Answer.Text += " пять\n"; break;
                    case 6: Answer.Text += " шесть\n"; break;
                    case 7: Answer.Text += " семь\n"; break;
                    case 8: Answer.Text += " восемь\n"; break;
                    case 9: Answer.Text += " девять\n"; break;
                }
            }
        }
    }
}

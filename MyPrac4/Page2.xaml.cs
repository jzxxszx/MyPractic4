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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(numberbox.Text, out int n)) MessageBox.Show("Поле только для чисел!");
            if (!int.TryParse(mastbox.Text, out int m)) MessageBox.Show("Нет такой масти");
            switch(n)
            {
                case 6:
                    Answer.Text += ("Шестерка ");
                    break;
                case 7:
                    Answer.Text += ("Семерка ");
                    break;
                case 8:
                    Answer.Text += ("Восьмерка ");
                    break;
                case 9:
                    Answer.Text += ("Девятка ");
                    break;
                case 10:
                    Answer.Text += ("Десятка ");
                    break;
                case 11:
                    Answer.Text += ("Валет ");
                    break;
                case 12:
                    Answer.Text += ("Дама ");
                    break;
                case 13:
                    Answer.Text += ("Король ");
                    break;
                case 14:
                    Answer.Text += ("Туз ");
                    break;
                default:
                    Answer.Text += ("ОШИБКА!");
                    break;
            }
            switch(m)
            {
                case 1:
                    Answer.Text += ("пики");
                    break;
                case 2:
                    Answer.Text += ("трефы");
                    break;
                case 3:
                    Answer.Text += ("бубен");
                    break;
                case 4:
                    Answer.Text += ("черви");
                    break;
                default:
                    Answer.Text += ("ОШИБКА!");
                    break;
                        
            }
        }
    }
}

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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!int.TryParse(daybox.Text, out int day)) MessageBox.Show("Поле только для чисел!");
            switch(day)
            {
                case 1:
                    Answer.Text += ("Понедельник");
                    break;
                case 2:
                    Answer.Text += ("Вторник");
                    break;
                case 3:
                    Answer.Text += ("Среда");
                    break;
                case 4:
                    Answer.Text += ("Четверг");
                    break;
                case 5:
                    Answer.Text += ("Пятница");
                    break;
                case 6:
                    Answer.Text += ("Суббота");
                    break;
                case 7:
                    Answer.Text += ("Воскресенье");
                    break;
                default:
                    Answer.Text += ("ОШИБКА!");
                    break;

            }
        }
    }
}

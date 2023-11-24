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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!double.TryParse(NumberP.Text, out double p))
            {
                MessageBox.Show("Введите число!");
            }

            int k = 1;
            double summa = 1000;

            if (0 < p && p <= 25)
            {
                while (summa <= 1100)
                {
                    ++k;
                    summa += summa * p / 100;
                }
            }
            else
            {
                MessageBox.Show("Нужно вводить от 0 до 25");
            }
            Answer.Text += $"{summa}\n";
        }
    }
}

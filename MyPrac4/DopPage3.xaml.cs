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
    /// Логика взаимодействия для DopPage3.xaml
    /// </summary>
    public partial class DopPage3 : Page
    {
        public DopPage3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer.Clear();
            if (!double.TryParse(NumberA.Text, out double a))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(NumberB.Text, out double b))
            {
                MessageBox.Show("Введите число!");
            }
            double answer;

            while (a != 0 & b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            answer = a + b;
            Answer.Text += $"НОД={answer}\n";
        }
    }
}

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

namespace Pr3_003
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
            int a = int.Parse(number1TextBox.Text);
            int b = int.Parse(number2TextBox.Text);
            int c = int.Parse(number3TextBox.Text);
            int d = int.Parse(number4TextBox.Text);
            int n = 0;
            if (a != b && a != c && a != d)
            {
                n = 1;
            }
            else if (b != a && b != c && b != d)
            {
                n = 2;
            }
            else if (c != a && c != b && c != d)
            {
                n = 3;
            }
            else
            {
                n = 4;
            }
            txtOtv.Text = $"Порядковый номер числа: {n}";
        }
    }
}

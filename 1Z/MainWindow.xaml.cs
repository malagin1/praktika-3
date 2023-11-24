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

namespace _1Z
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
            int c, z;
            if (!int.TryParse(Text1.Text, out int x))
            {

            }
            c = x / 10;
            z = x % 10;
            if ((c + z) % 3 == 0)
            {
                Text2.Text += "Да\n";
            }
            else
            {
                Text2.Text += "Нет\n";

            }
        }
        }            
}

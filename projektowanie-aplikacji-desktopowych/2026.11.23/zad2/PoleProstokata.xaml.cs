using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace zad2
{
    /// <summary>
    /// Interaction logic for PoleProstokata.xaml
    /// </summary>
    public partial class PoleProstokata : Window
    {
        public PoleProstokata()
        {
            InitializeComponent();
        }
        private void obliczButton_Click(object sender, RoutedEventArgs e)
        {
            wynik.Text = Convert.ToString(int.Parse(liczbaA.Text) * int.Parse(liczbaB.Text));
        }
    }
}

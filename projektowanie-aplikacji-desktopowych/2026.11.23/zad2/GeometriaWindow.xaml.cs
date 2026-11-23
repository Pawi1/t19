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
using zad1;

namespace zad2
{
    /// <summary>
    /// Interaction logic for GeometriaWindow.xaml
    /// </summary>
    public partial class GeometriaWindow : Window
    {
        public GeometriaWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var w = new PoleKola { Owner = this };
            w.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var w = new PoleProstokata { Owner = this };
            w.ShowDialog();
        }
    }
}

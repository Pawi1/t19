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

namespace zad1
{
    /// <summary>
    /// Interaction logic for DodawanieWindow.xaml
    /// </summary>
    public partial class DodawanieWindow : Window
    {
        private MainWindow _mainWindow;
        public DodawanieWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            _mainWindow.Show();
        }

        private void obliczButton_Click(object sender, RoutedEventArgs e)
        {
            wynik.Text = Convert.ToString(int.Parse(liczbaA.Text) + int.Parse(liczbaB.Text));
        }
    }
}

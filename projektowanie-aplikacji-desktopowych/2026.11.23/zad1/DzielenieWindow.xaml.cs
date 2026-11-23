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
    /// Interaction logic for DzielenieWindow.xaml
    /// </summary>
    public partial class DzielenieWindow : Window
    {
        public DzielenieWindow()
        {
            InitializeComponent();
        }


        private void obliczButton_Click(object sender, RoutedEventArgs e)
        {
            if (liczbaA.Text != "0" && liczbaB.Text != "0")
                wynik.Text = Convert.ToString(int.Parse(liczbaA.Text) / int.Parse(liczbaB.Text));
            else
                MessageBox.Show("Nie można dzielić przez zero");
        }
    
    }
}

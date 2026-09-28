using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zad2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dni = int.Parse(tbD.Text);
            double obnizka = (bool)rbU.IsChecked ? 0.5 : 1;
            double cena = 0;
            string strefa = "";
            if (cbA.IsSelected)
            {
                cena = 3.6 * dni * obnizka;
                strefa = "A";
            }

            else if (cbB.IsSelected)
            {
                cena = 4.6 * dni * obnizka;
                strefa = "B";
            }
            else if (cbAB.IsSelected)
            {
                cena = 5.4 * dni * obnizka;
                strefa = "AB";
            }
            if (cena != 0 && strefa != "")
                tbP.Text = $"Łączny koszt biletu na {dni} dni w strefie {strefa} to: {cena}";
        }
    }
}
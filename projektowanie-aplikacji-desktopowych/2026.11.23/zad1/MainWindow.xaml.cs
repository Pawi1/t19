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

namespace zad1
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
        private void dodawanieButton_Click(object sender, RoutedEventArgs e)
        {
            var dodWin = new DodawanieWindow(this);
            Hide();
            dodWin.Show();
        }

        private void odejmowanieButton_Click(object sender, RoutedEventArgs e)
        {
            var odWin = new OdejmowanieWindow(this);
            Hide();
            odWin.Show();
        }

        private void mnozenieButton_Click(object sender, RoutedEventArgs e)
        {
            var odWin = new MnozenieWindow{ Owner = this };
            odWin.ShowDialog();
        }

        private void dzielenieButton_Click(object sender, RoutedEventArgs e)
        {
            var odWin = new DzielenieWindow{ Owner = this };
            odWin.ShowDialog();
        }
   
    }
}
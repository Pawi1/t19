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

namespace zadanie1
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

        private void wyswietl_Checked(object sender, RoutedEventArgs e)
        {
            var _figura = (RadioButton) sender;
            try
            {
                figura.Source = new BitmapImage(new Uri("obrazy/" + $"{_figura.Content}.png", UriKind.Relative));
            }
            catch (Exception ex)
            {
                return;
            }
        }

    }
}
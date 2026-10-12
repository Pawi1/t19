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

namespace slider
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

        private void slider_r_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try
            {
                byte r = (byte)slider_r.Value,
                      g = (byte)slider_g.Value,
                      b = (byte)slider_b.Value;
                area.Background = new SolidColorBrush(Color.FromRgb(r,g,b));
                colour.Text = $"({r},{g},{b})";
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
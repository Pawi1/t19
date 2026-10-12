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

namespace zadanie2
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
        public void onUpdate()
        {
            czciaka_val.Text = czciaka.Value.ToString();
            zaokroglenie_val.Text = zaokroglenie.Value.ToString();
            ramka_val.Text = ramka.Value.ToString();

            border_text.Text = text.Text;
            border_text.FontSize = czciaka.Value;
            border.BorderThickness = new Thickness(ramka.Value);
            border.CornerRadius = new CornerRadius(zaokroglenie.Value);
        }

        private void czciaka_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            try {
                onUpdate();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void text_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                onUpdate();
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
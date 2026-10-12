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
        private Dictionary<string, (int, string,bool)> uslugi = new()
        {
            { "malowanie", (400 , "Malowanie",false) },
            { "podloze", (100,"Przygotowanie podłoża",false) },
            { "instalacja", (800,"Wykonanie instalacji elektrycznej",false) },
            { "gniazdka", (150,"Montaż gniazdek",false) },
            { "podlaczenie", (300,"Podłączenie urządzeń",false) }
        };
        private void malowanie_Checked(CheckBox sender, RoutedEventArgs e)
        {
            string key = sender.Name ?? "";

            if (uslugi.TryGetValue(key, out var usluga))
            {
                usluga.Item3 = !usluga.Item3;
                uslugi[key] = usluga;
            }
            if (uslugi.Values.Any(usluga => usluga.Item3 == true))
            {
                podsumowanie.Foreground = Brushes.Black;
                podsumowanie.TextDecorations.Clear();
            }
            else
            {
                podsumowanie.Text = "Musisz wybrać co najmniej jedną usługę";
                podsumowanie.Foreground = Brushes.Red;
                podsumowanie.TextDecorations = TextDecorations.Underline;
            }
        }

        private void podloze_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void instalacja_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void gniazdka_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void podlaczenie_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void malowanie_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
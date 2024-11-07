using System.Reflection.Emit;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2024._09._11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    // Zad 1. Mają być 2 textboxy (placeholder imie, nazwisko) i dwa butony. Po kliknieciu w jeden z buttonów ma wyskoczyc messageBox z napisem: Witaj imie i nazwisko
    //    A drugi button zamyka apke poprzedzajac to messboxem(baj baj)

    // Zad 2. Napisz program w WPF, w którym podajesz dane o osobie:
    // 1 - textbox imie
    // 2 - radio płeć
    // 3 - checkbox hobby   ??
    // 4 - textarea o sobie

    // Po kliknięciu w button zapisz -> całość danych zapisać do pliku
    // Inny button zamyka program.Można dodać labele informacyjne.

    // Zad 3. Stwórz program, który wyświetla drzewo plików w Windows. 
    // Dodatkowo stwórz prosty edytor, który tworzy plik tekstowy *.txt
    // (nazwa, zawartość) i zapisuje na dysku.
    // Nazwa pliku może być wpisywana przez usera albo generowana przez program
    // np: plik_bieżącyczas.txt
    // Zapis może być na fix - w określonym w programie miejscu.
    // Jak się uda to niech user decyduje o miejscu zapisu pku
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnSendClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Witaj {name.Text} {surname.Text}");
        }

        private void OnExitClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Baj Baj");
            Close();
        }
    }
}
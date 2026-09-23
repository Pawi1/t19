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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            Dictionary<string, bool?> selectedOptions = new Dictionary<string, bool?>
            {
                ["+"] = addButton.IsChecked,
                ["-"] = subtractButton.IsChecked,
                ["*"] = multiplyButton.IsChecked,
                ["/"] = divideButton.IsChecked
            };
            try
            {
                double number1Value = double.Parse(number1.Text);
                double number2Value = double.Parse(number2.Text);
                string result = "";
                foreach (var state in selectedOptions)
                {
                    if (state.Value == true)
                    {
                        result += $"{number1Value}{state.Key}{number2Value} = {Calc.Calculate(number1Value, number2Value, state.Key)}\n";
                    }
                }
                if (result != "")
                {
                    resultLabel.Content = $"Wynik:\n{result}";
                }
                else
                {
                    resultLabel.Content = "Nie wybrano żadnej operacji";
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Nie można dzielić przez zero");
            }
            catch(FormatException)
            {
                MessageBox.Show("Podaj prawidłowe liczby.");
            }
        }
    }
}
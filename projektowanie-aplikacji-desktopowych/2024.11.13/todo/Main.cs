using System.IO;
using System.Text.Json;
namespace todo
{
    public partial class Main : Form
    {
        public enum Gender
        {
            men,
            women,
            other
        }
        public class Person
        {
            public required string Name { get; set; }
            public required Gender Gender { get; set; }
            public required string Aboutme { get; set; }
        }
        public Main()
        {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(Main_FormClosing);
        }

        private void Main_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void CenterLabel(Label label, int fixedY = 380)
        {
            int centerX = (ClientSize.Width - label.Width) / 2;
            label.Location = new Point(centerX, fixedY);
        }
        private async static void ClearLabel(Label label, int ms = 4000)
        {            
            await Task.Delay(ms);
            label.Text = "";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            label_warning.Text = "";
            try
            {
                Gender? gender = null;
                if (radiobutton_men.Checked)
                    gender = Gender.men;
                else if (radiobutton_women.Checked)
                    gender = Gender.women;
                else if (radiobutton_other.Checked)
                    gender = Gender.other;
                var aboutme = textarena_aboutMe.Text;
                var name = textbox_name.Text;

                if (name is "" || aboutme is "" || gender is null)
                    throw new ArgumentNullException();
                
                Person person = new()
                {
                    Name = name,
                    Gender = (Gender)gender,
                    Aboutme = aboutme
                };
                
                List<Person> persons;
                
                if (File.Exists("db.json"))
                {
                    string json = File.ReadAllText("db.json");
                    persons = JsonSerializer.Deserialize<List<Person>>(json) ?? [];
                }
                else
                {
                    persons = [];
                }
                persons.Add(person);
                string newJson = JsonSerializer.Serialize(persons, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("db.json", newJson);
                label_warning.Text = "Została dokonana aktualizacja bazy danych";
                CenterLabel(label_warning);
            }
            catch (ArgumentNullException)
            {
                label_warning.Text = "Nie podałeś któregoś z argumentów, spróbuj ponownie";
                CenterLabel(label_warning);
            }
            ClearLabel(label_warning);
        }

        private void DisplayList_Click(object sender, EventArgs e)
        {
            DisplayList displayList = new()
            {
                StartPosition = FormStartPosition.Manual,
                Location = Location
            };
            displayList.Show();
            Hide();
        }
    }
}

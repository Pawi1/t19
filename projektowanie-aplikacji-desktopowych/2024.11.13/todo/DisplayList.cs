using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static todo.Main;

namespace todo
{
    public partial class DisplayList : Form
    {
        public DisplayList()
        {
            InitializeComponent();
            LoadDate();
            FormClosing += new FormClosingEventHandler(DisplayList_FormClosing);
        }

        private void DisplayList_FormClosing(object? sender, FormClosingEventArgs e)
        {
            e.Cancel = true; 

            Main main = Application.OpenForms["Main"] as Main ?? new Main();
            main.Location = Location;

            Hide();
            main.Show(); 
        }
        private void LoadDate()
        {
            if (File.Exists("db.json"))
            {
                var jsonData = File.ReadAllText("db.json");
                var dataList = JsonSerializer.Deserialize<List<Person>>(jsonData);

                dataGrid_list.DataSource = dataList;
                foreach (DataGridViewColumn column in dataGrid_list.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

            }
        }
        private void Button_return_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

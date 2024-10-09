namespace zadania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> list;
        private void button2_Click(object sender, EventArgs e) // Draw
        {
            list = Draw.RandomList(Convert.ToInt32(textBox1.Text));
            label2.Text = "Lista to: "+string.Join(' ',list);
            EnableDisableSort(true);
            EnableDisableDraw(false);
        }

        private void button1_Click(object sender, EventArgs e) // Sort
        {
            if (radioButton1.Checked)
                list = Sort.BubbleSort(list);
            else if (radioButton2.Checked)
                list = Sort.QuickSortHoare(list);
            else if (radioButton3.Checked)
                list = Sort.QuickSortLomuto(list);
            else
                MessageBox.Show("Błąd");
            label2.Text = "Lista to: " + string.Join(' ', list);
            EnableDisableSort(false);
            EnableDisableDraw(true);
        }
        private void EnableDisableSort(bool condition)
        {
            radioButton1.Enabled = condition;
            radioButton2.Enabled = condition;
            radioButton3.Enabled = condition;
            button1.Enabled = condition;
        }
        private void EnableDisableDraw(bool condition)
        {
            button2.Enabled = condition;
            textBox1.Enabled = condition;
        }
    }
}

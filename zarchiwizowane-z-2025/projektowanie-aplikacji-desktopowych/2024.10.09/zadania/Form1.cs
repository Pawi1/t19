namespace zadania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = (algorytm.CzyZaprzyjazniona(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text))) ? "TAK" : "NIE";
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Nie podałeś liczb naturalnych, spróbuj ponownie...");
            }
        }
    }
}

namespace sigma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static public bool isSigma(int sum)
        {
            string sumString = sum.ToString();
            char sigma = sumString[0];
            foreach (var item in sumString)
            {
                if(sigma != item)
                    return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string dateTimeString = dateTimePicker_sigma.Value.ToString("yyyy MM dd");
            string[] dateTimeListString = dateTimeString.Split(' ');
            int sum = 0;
            foreach (var item in dateTimeListString)
            {
                sum += Convert.ToInt16(item);
            }
            string result = isSigma(sum) ? "Jesteś" : "Nie jesteś";
            MessageBox.Show(result);
        }
    }
}

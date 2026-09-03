using System.Windows.Forms;

namespace zadanie
{
    public partial class Form1 : Form
    {
        public int[] Reszta(int[] jednostki, int x)
        {
            List<int> W = new List<int>();
            foreach (var i in jednostki)
            {
                int ilosc = x / i;
                if (ilosc > 0)
                {
                    x -= ilosc * i;
                    for (int j = 0; j < ilosc; j++)
                    {
                        W.Add(i);
                    }
                }
            }
            return W.ToArray();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            int[] jednostki = {200,100,50,20,10,5,2,1};
            int[] wydanie = Reszta(jednostki,Convert.ToInt32(textBox1.Text));
            //MessageBox.Show(string.Join(",",wydanie));
            int x = -10;
            foreach (var i in wydanie)
            {
                PictureBox pictureBox = new PictureBox();

                pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(i + "zl");
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }
    }
}

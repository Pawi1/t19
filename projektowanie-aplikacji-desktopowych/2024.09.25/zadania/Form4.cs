using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadania
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nwd(int a, int b)
            {
                while (b > 0)
                { 
                    int temp_a = a;
                    a = b;
                    b = temp_a % b;
                }
                return a;
            }
            int nww(int a, int b)
            {
                return (a * b / nwd(a, b));
            }

            label1.Text = Convert.ToString(nwd(Convert.ToInt32(textBox1), Convert.ToInt32(textBox2))) +"  "+ Convert.ToString(nww(Convert.ToInt32(textBox1), Convert.ToInt32(textBox2)));
        }
    }
}

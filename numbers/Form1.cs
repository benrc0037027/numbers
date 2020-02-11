using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double d1 = 5e6;
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("N") + "\n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00E00") + "\n");

            double pi = 3.141592653589793;
            richTextBox1.AppendText(pi.ToString("N9") + "\n");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string st = "three";
            try
            {
                int it = int.Parse(st);
            }
            catch
            {
                MessageBox.Show(st + " is not a integer");
            }

            string s2 = "3.2";
            try
            {
                int it = int.Parse(s2);
            }
            catch
            {
                double d2 = 0;


                string s3 = "pi";
                try
                {
                    double d2 = double.Parse(s3);
                }
                 catch
                {
                    double d2 = 0;
                }
                
            }
        }
    }
}

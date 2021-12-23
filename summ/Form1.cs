using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace summ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s;
        double a;
        double b;
        double c;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

             if (textBox1.Text == "")
             {
                 a = 0;
             }
             else
             {
                 s = textBox1.Text;
                 a = Convert.ToDouble(s);
             }
             c = a / b;
             textBox3.Text = Convert.ToString(c);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             if (textBox2.Text == "")
             {
                 b = 0;
             }
             else
             {
                 s = textBox2.Text;
                 b = Convert.ToDouble(s);
             }
             c = a / b;
             textBox3.Text = Convert.ToString(c);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter("test.txt");
            f.WriteLine("Строка1");
            f.WriteLine("Строка2");
            f.WriteLine("Строка3");
            f.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form dlg1 = new Form();
            dlg1.ShowDialog();
  

        }
    }
}

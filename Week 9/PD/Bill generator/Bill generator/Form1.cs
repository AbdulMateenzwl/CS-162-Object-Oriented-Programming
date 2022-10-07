using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bill_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f1 = 0, f2 = 0, f3 = 0;
            if (textBox6.Text != "")
            {
                f1 = float.Parse(textBox6.Text) * 9.95f;
                textBox8.Text = f1.ToString();
            }
            if (textBox15.Text != "")
            {
                f2 = float.Parse(textBox15.Text) * 19.95f;
                textBox13.Text = f2.ToString();
            }
            if (textBox11.Text != "")
            {
                f3 = float.Parse(textBox11.Text) * 14.95f;
                textBox9.Text = f3.ToString();
            }
            textBox17.Text = "Total : $" + f1 + f2 + f3;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox15.Clear();
            textBox11.Clear();
            textBox8.Clear();
            textBox13.Clear();
            textBox9.Clear();
            textBox17.Text = "Total : $";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

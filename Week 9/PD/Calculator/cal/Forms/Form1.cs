using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cal.BL;
namespace cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string line="";
        bool point = false;
        public double num1=0.0d;
        public double num2=0.0d;
        char op='+';
    
        private void button20_Click(object sender, EventArgs e)
        {
            line_add("0");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            line_add("7");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            line_add("4");
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            line_add("3");

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            line_add("2");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            line_add("6");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            line_add("5");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            line_add("9");
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            line_add("1");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            line_add("8");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            line_add(".");
        }
        private void line_add(string adder)
        {
            if (adder == "." && point == false)
            {
                point = true;
                line = line + adder;
            }
            else if (point == false)
            {
                line = line + adder;
            }
            else if (point == true && adder != ".")
            {
                line = line + adder;
            }
            textBox1.Text = line;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            check();
            num2 = 0.0;
            line = "";
            op = '+';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = 0.0d;
            num2 = 0.0d;
            line ="";
            op = '+';
            point=false;
            textBox1.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(line.Length>0)
            {
                line=line.Substring(0,line.Length-1);
            }
            textBox1.Text=line;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            if(line!="")
            {
                check();
                num2 = double.Parse(line);
                line ="";
            }
            op = '+';
            textBox3.Text = op.ToString();
            point=false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (line != "")
            {
                check();    
                num2 = double.Parse(line);
                line ="";
            }
            op = '-';
            point = false;
            textBox3.Text = op.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (line != "")
            {
                check();
                num2 = double.Parse(line);
                line ="";
            }
            op = '*';
            point = false;
            textBox3.Text = op.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (line != "")
            {
                check();
                num2 = double.Parse(line);
                line ="";
            }
            op = '/';
            point = false;
            textBox3.Text = op.ToString();
        }
        private void check()
        {
            if (line != "")
            {
                num2 = double.Parse(line);
                //line = "";
            }
            line = Operation.operate(num1, num2, op).ToString();
            textBox1.Text = line;
            num1 = double.Parse(line);
            textBox3.Clear();
        }
    }
}

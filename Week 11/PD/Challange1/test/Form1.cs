using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public List<string> list = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list.Add("Mateen");
            list.Add("Saqib");
            list.Add("Khadim");
            userControl11.List = list;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            
        }
    }
}
